using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing;
using System.Security.Principal;
using System.Reflection;
using System.Windows.Forms;

#region "DataGridPrinter"
//\\ --[DataGridPrinter]----------------------------------------------
//\\ Provides a way to print a nicely formatted page from a data grid
//\\ control.
//\\ -----------------------------------------------------------------
public class DataGridPrinter {

    #region "Private enumerated types"
    public enum CellTextHorizontalAlignment {
        LeftAlign = 1,
        CentreAlign = 2,
        RightAlign = 3
    }

    public enum CellTextVerticalAlignment {
        TopAlign = 1,
        MiddleAlign = 2,
        BottomAlign = 3
    }
    #endregion

    #region "Private properties"

    //\\ Printing the report related
    private PrintDocument withEventsField__GridPrintDocument;
    private PrintDocument _GridPrintDocument {
        get { return withEventsField__GridPrintDocument; }
        set {
            if (withEventsField__GridPrintDocument != null) {
                withEventsField__GridPrintDocument.BeginPrint -= _GridPrintDocument_BeginPrint;
                withEventsField__GridPrintDocument.PrintPage -= _GridPrintDocument_PrintPage;
            }
            withEventsField__GridPrintDocument = value;
            if (withEventsField__GridPrintDocument != null) {
                withEventsField__GridPrintDocument.BeginPrint += _GridPrintDocument_BeginPrint;
                withEventsField__GridPrintDocument.PrintPage += _GridPrintDocument_PrintPage;
            }
        }
    }

    private DataGridView _DataGrid;
    //\\ Print progress variables
    private int _CurrentPrintGridLine;
    private int _CurrentPageDown;

    private int _CurrentPageAcross = 1;
    //\\ Fonts to use to do the printing...
    private Font _PrintFont = new Font(System.Drawing.FontFamily.GenericSansSerif, 9);
    private Font _HeaderFont = new Font(System.Drawing.FontFamily.GenericSansSerif, 12);

    private Font _FooterFont = new Font(System.Drawing.FontFamily.GenericSansSerif, 10);
    private Rectangle _HeaderRectangle;
    private Rectangle _FooterRectangle;
    private Rectangle _PageContentRectangle;

    private double _Rowheight;
    //\\ Column widths related
    private int _PagesAcross = 1;

    private ColumnBounds _ColumnBounds = new ColumnBounds();


    private System.Drawing.StringFormat _Textlayout;
    private int _FooterHeightPercent = 3;
    private int _HeaderHeightPercent = 7;
    private int _InterSectionSpacingPercent = 2;

    private int _CellGutter = 5;
    //\\ Pens to draw the sections with
    private Pen _FooterPen = new Pen(Color.Green);
    private Pen _HeaderPen = new Pen(Color.RoyalBlue);

    private Pen _GridPen = new Pen(Color.Black);
    //\\ Brushes to fill the sections with
    private Brush _HeaderBrush = Brushes.White;
    private Brush _FooterBrush = Brushes.White;
    private Brush _ColumnHeaderBrush = Brushes.White;
    private Brush _OddRowBrush = Brushes.White;

    private Brush _EvenRowBrush = Brushes.White;
    private string _HeaderText;

    private string _LoggedInUsername;

    private int _GridRowCount;

    private int _GridColumnCount;
    #endregion

    #region "Public interface"

    #region "Properties"

    #region "PagesAcross"
    public int PagesAcross {
        get { return _PagesAcross; }
        set {
            if (value < 1) {
                throw new ArgumentOutOfRangeException("PagesAcross", "Must be one or more pages across");
            }
            _PagesAcross = value;
        }
    }
    #endregion

    #region "FooterHeightPercent"
    public int FooterHeightPercent {
        get { return _FooterHeightPercent; }
        set {
            if (value < 0 || value >= 30) {
                throw new ArgumentException("FooterHeightPercent must be between 0 and 30");
            }
            _FooterHeightPercent = value;
        }
    }
    #endregion
    #region "HeaderHeightPercent"
    public int HeaderHeightPercent {
        get { return _HeaderHeightPercent; }
        set {
            if (value < 0 || value >= 30) {
                throw new ArgumentException("HeaderHeightPercent must be between 0 and 30");
            }
            _HeaderHeightPercent = value;
        }
    }
    #endregion
    #region "InterSectionSpacingPercent"
    public int InterSectionSpacingPercent {
        get { return _InterSectionSpacingPercent; }
        set {
            if (value < 0 || value >= 20) {
                throw new ArgumentException("InterSectionSpacingPercent must be between 0 and 20");
            }
            _InterSectionSpacingPercent = value;
        }
    }
    #endregion

    #region "CellGutter"
    public int CellGutter {
        get { return _CellGutter; }
        set {
            if (value < 0 || value >= 10) {
                throw new ArgumentException("CellGutter must be between 0 and 10");
            }
            _CellGutter = value;
        }
    }
    #endregion

    #region "HeaderFont"
    public Font HeaderFont {
        get { return _HeaderFont; }
        //\\ Possible font size validation here..
        set { _HeaderFont = value; }
    }
    #endregion
    #region "PrintFont"
    public Font PrintFont {
        get { return _PrintFont; }
        //\\ Possible font size validation here
        set { _PrintFont = value; }
    }
    #endregion
    #region "FooterFont"
    public Font FooterFont {
        get { return _FooterFont; }
        //\\ Possible font size validation here
        set { _FooterFont = value; }
    }
    #endregion

    #region "HeaderText"
    public string HeaderText {
        get { return _HeaderText; }
        set { _HeaderText = value; }
    }
    #endregion

    #region "HeaderPen"
    public Pen HeaderPen {
        get { return _HeaderPen; }
        set { _HeaderPen = value; }
    }
    #endregion
    #region "FooterPen"
    public Pen FooterPen {
        get { return _FooterPen; }
        set { _FooterPen = value; }
    }
    #endregion
    #region "GridPen"
    public Pen GridPen {
        get { return _GridPen; }
        set { _GridPen = value; }
    }
    #endregion

    #region "HeaderBrush"
    public Brush HeaderBrush {
        get { return _HeaderBrush; }
        set { _HeaderBrush = value; }
    }
    #endregion
    #region "FooterBrush"
    public Brush FooterBrush {
        get { return _FooterBrush; }
        set { _FooterBrush = value; }
    }
    #endregion
    #region "ColumnHeaderBrush"
    public Brush ColumnHeaderBrush {
        get { return _ColumnHeaderBrush; }
        set { _ColumnHeaderBrush = value; }
    }
    #endregion
    #region "OddRowBrush"
    public Brush OddRowBrush {
        get { return _OddRowBrush; }
        set { _OddRowBrush = value; }
    }
    #endregion
    #region "EvenRowBrush"
    public Brush EvenRowBrush {
        get { return _EvenRowBrush; }
        set { _EvenRowBrush = value; }
    }
    #endregion

    #region "PrintDocument"
    public PrintDocument PrintDocument {
        get { return _GridPrintDocument; }
    }
    #endregion

    #region "DataGrid"
    public DataGridView DataGrid {
        set { _DataGrid = value; }
    }
    #endregion

    #endregion

    #region "Methods"

    #region "Shared methods"
    //\\ --[StripDomainFromFullUsername]------------------------------------------------
    //\\ Returns just the username bit from a username that includes a domain name
    //\\ e.g. "DEVELOPMENT\Duncan" -> "Duncan"
    //\\ (c) 2005 - Merrion Computing Ltd
    //\\ -------------------------------------------------------------------------------
    public static string StripDomainFromFullUsername(string FullUsername) {

        if (FullUsername.IndexOf("\\") == -1) {
            return FullUsername;
        }
        else {
            char[] sep = { char.Parse("\\") };
            string[] chaf = FullUsername.Split(sep);
            return (chaf[chaf.Length - 1]);
        }

    }
    #endregion

    #region "Print"
    public void Print() {
        _GridPrintDocument.Print();
    }
    #endregion
    #endregion


    #endregion

    #region "_GridPrintDocument events"

    private void _GridPrintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        //\\ Initialise the current page and current grid line variables
        _CurrentPrintGridLine = 1;
        _CurrentPageDown = 1;
        _CurrentPageAcross = 1;

        if (_Textlayout == null) {
            _Textlayout = new System.Drawing.StringFormat();
            _Textlayout.Trimming = StringTrimming.EllipsisCharacter;
        }

    }


    private void _GridPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
        if (_CurrentPageDown == 1 & _CurrentPageAcross == 1) {
            // _HeaderRectangle -  The top 10% of the page
            _HeaderRectangle = e.MarginBounds;
            _HeaderRectangle.Height = Convert.ToInt32(e.MarginBounds.Height * _HeaderHeightPercent * 0.01);

            // _FooterRectangle - the bottom 10% of the page
            _FooterRectangle = e.MarginBounds;
            _FooterRectangle.Height = Convert.ToInt32(e.MarginBounds.Height * _FooterHeightPercent * 0.01);
            _FooterRectangle.Y += Convert.ToInt32(e.MarginBounds.Height * (1 - (0.01 * _FooterHeightPercent)));

            // _PageContentRectangle - The middle 80% of the page
            _PageContentRectangle = e.MarginBounds;
            _PageContentRectangle.Y += Convert.ToInt32(_HeaderRectangle.Height + e.MarginBounds.Height * (_InterSectionSpacingPercent * 0.01));
            _PageContentRectangle.Height = Convert.ToInt32(e.MarginBounds.Height * 0.8);

            _Rowheight = e.Graphics.MeasureString("a", _PrintFont).Height;

            //\\ Create the _ColumnBounds array
            int nColumn = 0;
            double TotalWidth = 0;

            if (_DataGrid.DataSource == null) {
                //\\ Nothing in the grid to print
                return;
            }

            int ColumnCount = GridColumnCount();

            //for (nColumn = 0; nColumn <= ColumnCount - 1; nColumn++) {
            //    Rectangle rcLastCell = _DataGrid.Rows[0].Cells[nColumn].b;
            //    if (rcLastCell.Width > 0) {
            //        TotalWidth += rcLastCell.Width;
            //    }
            //}
            TotalWidth = _DataGrid.Width;
            int TotalWidthOfAllPages = (e.MarginBounds.Width * PagesAcross);
            _ColumnBounds.Clear();
            for (nColumn = 0; nColumn <= ColumnCount - 1; nColumn++) {
                //\\ Calculate the column start point
                ColumnBound NextColumn = new ColumnBound();
                if (nColumn == 0) {
                    NextColumn.Left = e.MarginBounds.Left;
                }
                else {
                    NextColumn.Left = _ColumnBounds.RightExtents;
                }
                //\\ Set this column's width
                int rcCellWidth = _DataGrid.Rows[0].Cells[nColumn].Size.Width;
                if (rcCellWidth > 0) {
                    rcCellWidth = rcCellWidth - 1;
                    NextColumn.Width = (rcCellWidth / TotalWidth) * TotalWidthOfAllPages;
                    if (NextColumn.Width > e.MarginBounds.Width) {
                        NextColumn.Width = e.MarginBounds.Width;
                    }
                }
                if (_ColumnBounds.RightExtents + NextColumn.Width > (e.MarginBounds.Left + e.MarginBounds.Width)) {
                    _ColumnBounds.NextPage();
                    NextColumn.Left = e.MarginBounds.Left;
                }
                _ColumnBounds.Add(NextColumn);
            }
            if (_ColumnBounds.TotalPages > this.PagesAcross) {
                this.PagesAcross = _ColumnBounds.TotalPages;
            }
        }

        //\\ Print the document header
        PrintHeader(e);

        //\\ Print as many grid lines as can fit
        Int32 nextLine = default(Int32);
        PrintGridHeaderLine(e);
        int StartOfpage = _CurrentPrintGridLine;
        for (nextLine = _CurrentPrintGridLine; nextLine <= Min((_CurrentPrintGridLine + RowsPerPage(_PrintFont, e.Graphics)), ((System.Data.DataTable)_DataGrid.DataSource).DefaultView.Count); nextLine++) {
            PrintGridLine(e, nextLine);
        }
        _CurrentPrintGridLine = nextLine;

        //\\ Print the document footer
        PrintFooter(e);

        if (_CurrentPageAcross == PagesAcross) {
            _CurrentPageAcross = 1;
            _CurrentPageDown += 1;
        }
        else {
            _CurrentPageAcross += 1;
            _CurrentPrintGridLine = StartOfpage;
        }

        //\\ If there are more lines to print, set the HasMorePages property to true
        if (_CurrentPrintGridLine < GridRowCount()) {
            e.HasMorePages = true;
        }

    }
    #endregion

    #region "Private methods"

    private void PrintHeader(System.Drawing.Printing.PrintPageEventArgs e) {
        if (_HeaderRectangle.Height > 0) {
            e.Graphics.FillRectangle(_HeaderBrush, _HeaderRectangle);
            e.Graphics.DrawRectangle(_HeaderPen, _HeaderRectangle);
            DrawCellString(_HeaderText, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _HeaderRectangle, false, e.Graphics, _HeaderFont, _HeaderBrush);
        }

    }


    private void PrintFooter(System.Drawing.Printing.PrintPageEventArgs e) {
        if (_FooterRectangle.Height > 0) {
            e.Graphics.FillRectangle(_FooterBrush, _FooterRectangle);
            e.Graphics.DrawRectangle(_FooterPen, _FooterRectangle);
            DrawCellString("Printed by " + _LoggedInUsername, CellTextHorizontalAlignment.LeftAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, false, e.Graphics, _PrintFont, Brushes.White);
            DrawCellString(DateTime.Now.ToLongDateString(), CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, false, e.Graphics, _PrintFont, Brushes.White);
            DrawCellString("Page " + (((_CurrentPageDown - 1) * PagesAcross) + _CurrentPageAcross).ToString(), CellTextHorizontalAlignment.RightAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, false, e.Graphics, _PrintFont, Brushes.White);
        }

    }


    private void PrintGridLine(System.Drawing.Printing.PrintPageEventArgs e, int RowNumber) {
        int RowFromTop = RowNumber + 1 - _CurrentPrintGridLine;
        double Top = _PageContentRectangle.Top + (RowFromTop * ((_CellGutter * 2) + _Rowheight));
        double Bottom = Top + _Rowheight + (2 * _CellGutter);

        Top = RoundTo(Top, 2);
        Bottom = RoundTo(Bottom, 2);

        object[] Items = null;
        try {
            if (_DataGrid.DataSource is DataTable) {
                Items = ((System.Data.DataTable)_DataGrid.DataSource).DefaultView[RowNumber - 1].Row.ItemArray;
            }
            else if (_DataGrid.DataSource is DataSet) {
                Items = ((System.Data.DataSet)_DataGrid.DataSource).Tables[_DataGrid.DataMember].DefaultView[RowNumber - 1].Row.ItemArray;
            }
            else if (_DataGrid.DataSource is DataView) {
                Items = ((System.Data.DataView)_DataGrid.DataSource).Table.DefaultView[RowNumber - 1].Row.ItemArray;
            }
            else {
                //TODO : Get the content for the current row ....
            }

            Brush RowBrush = null;
            if (((RowNumber % 2) == 0)) {
                RowBrush = _OddRowBrush;
            }
            else {
                RowBrush = _EvenRowBrush;
            }
            int nColumn = 0;
            for (nColumn = 0; nColumn <= Items.Length - 1; nColumn++) {
                if (_ColumnBounds[nColumn].Page == _CurrentPageAcross) {
                    Rectangle rcCell = new Rectangle(Convert.ToInt32(_ColumnBounds[nColumn].Left), Convert.ToInt32(Top), Convert.ToInt32(_ColumnBounds[nColumn].Width), Convert.ToInt32(Bottom - Top));
                    if (rcCell.Width > 0) {
                        string Columntext = null;
                        try {
                        //    Columntext = Convert.ToString(Items[MappedColumnToBaseColumn(nColumn)]);
                        }
                        catch {
                        }
                        DrawCellString(Columntext, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, true, e.Graphics, _PrintFont, RowBrush);
                    }
                }
            }
        }
        catch (Exception exIndex) {
            Trace.WriteLine(exIndex.ToString(), this.GetType().ToString());
        }

    }


    private void PrintGridHeaderLine(System.Drawing.Printing.PrintPageEventArgs e) {
        double Top = _PageContentRectangle.Top;
        double Bottom = Top + _Rowheight + (2 * _CellGutter);

        Top = RoundTo(Top, 2);
        Bottom = RoundTo(Bottom, 2);

        int nColumn = 0;

        for (nColumn = 0; nColumn <= GridColumnCount() - 1; nColumn++) {
            if (_ColumnBounds[nColumn].Page == _CurrentPageAcross) {
                Rectangle rcCell = new Rectangle(Convert.ToInt32(_ColumnBounds[nColumn].Left), Convert.ToInt32(Top), Convert.ToInt32(_ColumnBounds[nColumn].Width), Convert.ToInt32(Bottom - Top));
                if (rcCell.Width > 0) {
                  //  DrawCellString(GetColumnHeadingText(nColumn), CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, true, e.Graphics, _PrintFont, _ColumnHeaderBrush);
                }
            }
        }


    }

    private int RowsPerPage(Font GridLineFont, Graphics e) {

        return Convert.ToInt32((_PageContentRectangle.Height / ((_CellGutter * 2) + _Rowheight)) - 2);

    }


    public void DrawCellString(string s, CellTextHorizontalAlignment HorizontalAlignment, CellTextVerticalAlignment VerticalAlignment, Rectangle BoundingRect, bool DrawRectangle, Graphics Target, Font PrintFont, Brush FillColour) {

        float x = 0;
        float y = 0;

        if (DrawRectangle) {
            Target.FillRectangle(FillColour, BoundingRect);
            Target.DrawRectangle(_GridPen, BoundingRect);
        }

        //\\ Set the text alignment
        if (HorizontalAlignment == CellTextHorizontalAlignment.LeftAlign) {
            _Textlayout.Alignment = StringAlignment.Near;
        }
        else if (HorizontalAlignment == CellTextHorizontalAlignment.RightAlign) {
            _Textlayout.Alignment = StringAlignment.Far;
        }
        else {
            _Textlayout.Alignment = StringAlignment.Center;
        }

        RectangleF BoundingRectF = new RectangleF(BoundingRect.X + _CellGutter, BoundingRect.Y + _CellGutter, BoundingRect.Width - (2 * _CellGutter), BoundingRect.Height - (2 * _CellGutter));

        Target.DrawString(s, PrintFont, System.Drawing.Brushes.Black, BoundingRectF, _Textlayout);

    }

    //\\ --[RoundTo]-----------------------------------------------------------------------------
    //\\ Rounds the input number tot he nearest modulus of NearsetMultiple
    //\\ ----------------------------------------------------------------------------------------
    private int RoundTo(double Input, int NearestMultiple) {

        if (((Input % NearestMultiple) > (NearestMultiple / 2))) {
            return ((Convert.ToInt32(Input) / NearestMultiple) * NearestMultiple) + NearestMultiple;
        }
        else {
            return (Convert.ToInt32(Input) / NearestMultiple) * NearestMultiple;
        }

    }

    //\\ --[Min]------------------------------------------------------------
    //\\ Returns the minimum of two numbers
    //\\ -------------------------------------------------------------------
    private int Min(int a, int b) {
        if (a < b) {
            return a;
        }
        else {
            return b;
        }
    }

    private int GridColumnCount() {

        if (_GridColumnCount == 0) {
            if (_DataGrid.DataSource is DataTable) {
                _GridColumnCount = ((DataTable)_DataGrid.DataSource).Columns.Count;
            }
            else if (_DataGrid.DataSource is DataSet) {
                _GridColumnCount = ((DataSet)_DataGrid.DataSource).Tables[_DataGrid.DataMember].Columns.Count;
            }
            else if (_DataGrid.DataSource is DataView) {
                _GridColumnCount = ((DataView)_DataGrid.DataSource).Table.Columns.Count;
            }
            else {
                //TODO : Get the column count....
            }
        }
        return _GridColumnCount;

    }

    private int GridRowCount() {

        if (_GridRowCount == 0) {
            if (_DataGrid.DataSource is DataTable) {
                _GridRowCount = ((DataTable)_DataGrid.DataSource).DefaultView.Count;
            }
            else if (_DataGrid.DataSource is DataSet) {
                _GridRowCount = ((DataSet)_DataGrid.DataSource).Tables[_DataGrid.DataMember].DefaultView.Count;
            }
            else if (_DataGrid.DataSource is DataView) {
                _GridRowCount = ((DataView)_DataGrid.DataSource).Table.DefaultView.Count;
            }
            else {
                //TODO : Get the column count....
            }
        }
        return _GridRowCount;

    }

    //private string GetColumnHeadingText(int Column) {

    //    if (_DataGrid.TableStyles.Count > 0) {
    //        return _DataGrid.TableStyles[_DataGrid.TableStyles.Count - 1].GridColumnStyles[Column].HeaderText;
    //    }
    //    else {
    //        if (_DataGrid.DataSource is DataTable) {
    //            return ((DataTable)_DataGrid.DataSource).Columns[Column].Caption;
    //        }
    //        else if (_DataGrid.DataSource is DataSet) {
    //            return ((DataSet)_DataGrid.DataSource).Tables[0].Columns[Column].Caption;
    //        }
    //        else if (_DataGrid.DataSource is DataView) {
    //            return ((DataView)_DataGrid.DataSource).Table.Columns[Column].Caption;
    //        }
    //    }
    //    return "";
    //}

    //private int MappedColumnToBaseColumn(int MappedColumn) {

    //    if (_DataGrid.TableStyles.Count <= 1) {
    //        return MappedColumn;
    //    }
    //    else {
    //        //\\ Need to map from the column in the default to the column in the active map..
    //        return _DataGrid.TableStyles[0].GridColumnStyles.IndexOf(_DataGrid.TableStyles[_DataGrid.TableStyles.Count - 1].GridColumnStyles[MappedColumn]);
    //    }

    //}

    #endregion

    #region "Public constructors"

    public DataGridPrinter(DataGridView Grid) {
        //\\ Initialise the bits we need to use later
        _GridPrintDocument = new PrintDocument();
        _DataGrid = Grid;

        WindowsPrincipal LoggedInuser = new WindowsPrincipal(WindowsIdentity.GetCurrent());

        _LoggedInUsername = DataGridPrinter.StripDomainFromFullUsername(WindowsIdentity.GetCurrent().Name);

    }
    #endregion

}
#endregion

#region "ColumnBound"
public class ColumnBound {

    #region "Private properties"
    private int _Page = 1;
    private double _Left;
    #endregion
    private double _Width;

    #region "Public interface"
    public double Left {
        get { return _Left; }
        set {
            if (value < 0) {
                throw new ArgumentException("Left must be greater than zero");
            }
            _Left = value;
        }
    }

    public double Width {
        get { return _Width; }
        set {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than zero");
            }
            _Width = value;
        }
    }

    public int Page {
        get { return _Page; }
        set {
            if (value < 1) {
                throw new ArgumentOutOfRangeException("Page", "Must be greater than zero");
            }
            _Page = value;
        }
    }
    #endregion

}
#endregion
#region "ColumnBounds"
//\\ Type safe collection of "ColumnBound" objects
public class ColumnBounds : System.Collections.ArrayList {

    #region "Private properties"
    private int _CurrentPage = 1;
    //\\ How far right does this column set reach?
    private double _RightExtents;
    #endregion

    #region "ArrayList overrides"
    public int Add(ColumnBound ColumnBound) {
        if (ColumnBound.Left + ColumnBound.Width > _RightExtents) {
            _RightExtents = ColumnBound.Left + ColumnBound.Width;
        }
        ColumnBound.Page = _CurrentPage;
        return base.Add(ColumnBound);
    }

    public void Clear() {
        _CurrentPage = 1;
        _RightExtents = 0;
        base.Clear();
    }

    public void NextPage() {
        _CurrentPage += 1;
        _RightExtents = 0;
    }

    internal int TotalPages {
        get { return _CurrentPage; }
    }

    public new ColumnBound this[int Index] {
        get { return (ColumnBound)base[Index]; }
        set { base[Index] = value; }
    }
    #endregion

    #region "Public interface"
    public double RightExtents {
        get { return _RightExtents; }
    }
    #endregion

}
#endregion
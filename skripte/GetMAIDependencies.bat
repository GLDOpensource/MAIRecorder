echo off
set Output_Path=%~dp0%..\MAIRecorder\dependencies\
set Release_Path=D:\WorkingSVN\MAI_V2_2011\branches\working\Ausgabe\Release\

del %Output_Path%MAI.Controls.Configuration.NET20.dll
del %Output_Path%MAI_v2_ExtensionDAQ_NET20_DLL.dll
del %Output_Path%MAI_v2_NET20_DLL.dll
del %Output_Path%MemoryMappedFile_NET20_DLL.dll
del %Output_Path%NI_DDC_NET20_DLL.dll


copy %Release_Path%MAI.Controls.Configuration.NET20.dll %Output_Path%
copy %Release_Path%MAI_v2_ExtensionDAQ_NET20_DLL.dll    %Output_Path%
copy %Release_Path%MAI_v2_NET20_DLL.dll                 %Output_Path%
copy %Release_Path%MemoryMappedFile_NET20_DLL.dll       %Output_Path%
copy %Release_Path%NI_DDC_NET20_DLL.dll                 %Output_Path%
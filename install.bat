@ECHO OFF
SETLOCAL
SET RootDir=%~dp0.
IF NOT "%~2"=="" (SET TargetVisualStudioVersion=%~2)
CALL "%RootDir%\SetupEnvironment.bat"
IF NOT EXIST "%RootDir%\Version.bat" (
	CALL:_GenerateVersion
)
CALL "%RootDir%\Version.bat" %*

IF "%VSIXInstallDir%"=="" (
	IF EXIST "%OldNORMADir%\bin\Neumont.Tools.ORM.dll" (%RegPkg% /unregister "%NORMADir%\bin\Neumont.Tools.ORM.dll")
	IF EXIST "%OldNORMADir%\bin\Neumont.Tools.ORM.%TargetVisualStudioShortProductName%.dll" (%RegPkg% /unregister "%OldNORMADir%\bin\Neumont.Tools.ORM.%TargetVisualStudioShortProductName%.dll")
	CALL:_CleanupFile "%OldNORMADir%\bin\Neumont.Tools.ORM.dll"
	CALL:_CleanupFile "%OldNORMADir%\bin\Neumont.Tools.ORM.pdb"
	CALL:_CleanupFile "%OldNORMADir%\bin\Neumont.Tools.ORM.xml"
)

SET TargetBaseName=ORMSolutions.ORMArchitect.Core.%TargetVisualStudioShortProductName%
if EXIST "%VSDir%" (
	IF "%VSIXInstallDir%"=="" (
		IF EXIST "%NORMADir%\bin\%TargetBaseName%.dll" (%RegPkg% /unregister "%NORMADir%\bin\%TargetBaseName%.dll")
		IF NOT EXIST "%NORMADir%" (SET RunDevEnvSetup=True)
	)
)

CALL:_MakeDir "%NORMADir%\bin"
CALL:_RemoveDir "%NORMADir%\bin\1033"
CALL:_MakeDir "%NORMADir%\Help"
CALL:_MakeDir "%NORMADir%\Xml\Schemas"
CALL:_MakeDir "%NORMADir%\Xml\Transforms\Converters"
CALL:_MakeDir "%NORMADir%\Xml\Verbalization\Core"
CALL:_MakeDirCopy "%NORMADir%\Xml\Verbalization\HtmlReport" "%NORMADir%\Xml\Verbalization\Report"
CALL:_RemoveDir "%NORMADir%\Xml\Verbalization\Report"
CALL:_RemoveDir "%NORMADir%\ORMProjectItems"
CALL:_RemoveDir "%ORMDir%\..\..\ORM"
CALL:_MakeDir "%ORMDir%\Schemas"
CALL:_MakeDir "%ORMDir%\Transforms"
CALL:_RemoveDir "%DILDir%\..\..\DIL"
CALL:_MakeDir "%DILDir%\Schemas"
CALL:_MakeDir "%DILDir%\Transforms"

XCOPY /Y /D /V /Q "%RootDir%\ORMModel\%BuildOutDir%\%TargetBaseName%.dll" "%NORMADir%\bin\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\%BuildOutDir%\%TargetBaseName%.pdb" "%NORMADir%\bin\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\%BuildOutDir%\%TargetBaseName%.xml" "%NORMADir%\bin\"
CALL:_CleanupFile "%OldNORMADir%\bin\1033\Neumont.Tools.ORMUI.dll"

IF NOT "%ItemTemplatesInstallDir%"=="" (
	CALL:_MakeDir "%ItemTemplatesInstallDir%"
	IF "%TargetVisualStudioVersion%"=="v15.0" (
		XCOPY /Y /D /V /Q /S "%RootDir%\ORMModel\Shell\ProjectItems\%TargetVisualStudioShortProductName%" "%ItemTemplatesInstallDir%"
		XCOPY /Y /D /V /Q "%RootDir%\VSIXInstall\VS2017\ItemTemplateManifest.vstman" "%ItemTemplatesInstallDir%"
	) ELSE (
		FOR %%A IN ("%RootDir%\ORMModel\Shell\ProjectItems\*.zip") DO ECHO F | XCOPY /Y /D /V /Q "%%~fA" "%ItemTemplatesInstallDir%\%%~nA\ORMModel.zip"
		FOR %%A IN ("%RootDir%\ORMModel\Shell\ProjectItems\Web\*.zip") DO ECHO F | XCOPY /Y /D /V /Q "%%~fA" "%ItemTemplatesInstallDir%\Web\%%~nA\ORMModel.zip"
		IF "%VSIXInstallDir%"=="" (
			FOR %%A IN ("%RootDir%\ORMModel\Shell\ProjectItems\%TargetVisualStudioShortProductName%\*.zip") DO ECHO F | XCOPY /Y /D /V /Q "%%~fA" "%VSItemTemplatesDir%\%%~nA\ORMModel.zip"
		)
	)
)
IF NOT "%VSIXInstallDir%"=="" (
	IF EXIST "%VSEnvironmentDir%\NewFileItems" (
		FOR %%A IN ("%RootDir%\ORMModel\Shell\ProjectItems\NewFileItems\*.*") DO ECHO F | XCOPY /Y /D /V /Q "%%~fA" "%VSEnvironmentDir%\NewFileItems\%%~nxA"
	)
)

XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ObjectModel\ORM2Core.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ShapeModel\ORM2Diagram.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Load\ORM2Root.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\OIAL\OIAL.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\OIAL\ORMDataTypes.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\OIAL\ORMDataTypes-Temporal.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\OIALtoPLiX\OIALtoPLiX_Properties.xsd" "%ORMDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\catalog.xml" "%ORMDir%\Schemas\"

XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Shell\ORMDesignerSettings.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\CustomProperties\CustomProperties.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\AlternateViews\RelationalView\RelationalView.xsd" "%NORMADir%\Xml\Schemas\"
ECHO F | XCOPY /Y /D /V /Q "%RootDir%\Oial\OialModel\OIAL.xsd" "%NORMADir%\Xml\Schemas\ORMAbstraction.xsd"
ECHO F | XCOPY /Y /D /V /Q "%RootDir%\Oial\OialModel\OIALDatatypes.xsd" "%NORMADir%\Xml\Schemas\ORMAbstractionDataTypes.xsd"
XCOPY /Y /D /V /Q "%RootDir%\Oial\ORMOialBridge\ORMToORMAbstraction.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\RelationalModel\DcilModel\ConceptualDatabase.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\RelationalModel\OialDcilBridge\ORMAbstractionToConceptualDatabase.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\EntityRelationship\BarkerErModel\BarkerERModel.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\EntityRelationship\OialBerBridge\ORMAbstractionToBarkerERBridge.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\AlternateViews\BarkerERView\BarkerERView.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Framework\Shell\DiagramDisplay.xsd" "%NORMADir%\Xml\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Shell\catalog.xml" "%NORMADir%\Xml\Schemas\"
CALL:_CleanupFile "%NORMADir%\ORMDesignerSettings.xml"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Shell\ORMDesignerSettings.xml" "%NORMADir%\Xml\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\Shell\Converters\*.xslt" "%NORMADir%\Xml\Transforms\Converters\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ObjectModel\VerbalizationUntypedSnippets.xsd" "%NORMADir%\Xml\Verbalization\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ObjectModel\VerbalizationCoreSnippets\*.x??" "%NORMADir%\Xml\Verbalization\Core\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ObjectModel\VerbalizationReportSnippets\*.x??" "%NORMADir%\Xml\Verbalization\HtmlReport\"
XCOPY /Y /D /V /Q "%RootDir%\ORMModel\ObjectModel\VerbalizationCoreSnippetsDocumentation.html" "%NORMADir%\Xml\Verbalization\Core\"
IF EXIST "%NORMADir%\Xml\Verbalization\Core\VerbalizationCoreSnippets.xml" (
	CALL:_CleanupFile "%NORMADir%\Xml\Verbalization\Core\_default.xml"
	REN "%NORMADir%\Xml\Verbalization\Core\VerbalizationCoreSnippets.xml" "_default.xml"
)
IF EXIST "%NORMADir%\Xml\Verbalization\Core\VerbalizationCoreReportSnippets.xml" (
	CALL:_CleanupFile "%NORMADir%\Xml\Verbalization\Core\DefaultReportSnippets.xml"
	REN "%NORMADir%\Xml\Verbalization\Core\VerbalizationCoreReportSnippets.xml" "DefaultReportSnippets.xml"
)
IF EXIST "%NORMADir%\Xml\Verbalization\Core\BrowserNoHyperlinksSnippets.xml" (
	CALL:_CleanupFile "%NORMADir%\Xml\Verbalization\Core\BrowserNoHyperlinksSnippets.xml"
	REN "%NORMADir%\Xml\Verbalization\Core\VerbalizationCoreBrowserNoHyperlinksSnippets.xml" "BrowserNoHyperlinksSnippets.xml"
)
IF EXIST "%NORMADir%\Xml\Verbalization\HtmlReport\VerbalizationReportSnippets.xml" (
	CALL:_CleanupFile "%NORMADir%\Xml\Verbalization\HtmlReport\_default.xml"
	REN "%NORMADir%\Xml\Verbalization\HtmlReport\VerbalizationReportSnippets.xml" "_default.xml"
)

XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DIL.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DILDT.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DILEP.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DILMS.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DMIL.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DCIL.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\DDIL.xsd" "%DILDir%\Schemas\"
XCOPY /Y /D /V /Q "%RootDir%\XML\DIL\catalog.xml" "%DILDir%\Schemas\"

if EXIST "%VSDir%" (
SETLOCAL ENABLEDELAYEDEXPANSION
	ECHO F | XCOPY /Y /D /V /Q "%RootDir%\Setup\NORMASchemaCatalog.%TargetVisualStudioShortProductName%.xml" "%VSDir%\Xml\Schemas\NORMASchemaCatalog.xml"
	XCOPY /Y /D /V /Q "%RootDir%\Setup\ORMSchemaCatalog.xml" "%VSDir%\Xml\Schemas\"
	XCOPY /Y /D /V /Q "%RootDir%\Setup\DILSchemaCatalog.xml" "%VSDir%\Xml\Schemas\"

	IF "%VSIXInstallDir%"=="" (
		%RegPkg% "%NORMADir%\bin\%TargetBaseName%.dll"

		REG DELETE "HKLM\%VSRegistryRoot%\InstalledProducts\Natural ORM Architect" /v "UseRegNameAsSplashName" /f 1>NUL

		:: Get rid of our old project item registrations for the General, Misc, and Solution projects.
		REG DELETE "HKLM\%VSRegistryRoot%\Projects\{2150E333-8FDC-42A3-9474-1A3956D46DE8}\AddItemTemplates\TemplateDirs\{EFDDC549-1646-4451-8A51-E5A5E94D647C}" /f 1>NUL 2>&1
		REG DELETE "HKLM\%VSRegistryRoot%\Projects\{A2FE74E1-B743-11d0-AE1A-00A0C90FFFC3}\AddItemTemplates\TemplateDirs\{EFDDC549-1646-4451-8A51-E5A5E94D647C}" /f 1>NUL 2>&1
		REG DELETE "HKLM\%VSRegistryRoot%\Projects\{D1DCDB85-C5E8-11d2-BFCA-00C04F990235}\AddItemTemplates\TemplateDirs\{EFDDC549-1646-4451-8A51-E5A5E94D647C}" /f 1>NUL 2>&1

		:: Get rid of single-settings-file-only values
		REG DELETE "HKLM\%VSRegistryRoot%\ORM Solutions\Natural ORM Architect" /v "SettingsPath" /f 1>NUL 2>&1
		REG DELETE "HKLM\%VSRegistryRoot%\ORM Solutions\Natural ORM Architect" /v "ConvertersDir" /f 1>NUL 2>&1

		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\FontAndColors\Orm Designer" /v "Category" /d "{663DE24F-8E3A-4C0F-A307-53053ED6C59B}" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\FontAndColors\Orm Designer" /v "Package" /d "{C5AA80F8-F730-4809-AAB1-8D925E36F9F5}" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\FontAndColors\Orm Verbalizer" /v "Category" /d "{663DE24F-5A08-4490-80E7-EA332DFFE7F0}" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\FontAndColors\Orm Verbalizer" /v "Package" /d "{C5AA80F8-F730-4809-AAB1-8D925E36F9F5}" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\ShellFileAssociations\.orm" /ve /d "ormfile" /f 1>NUL

		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\XmlDesigners\{EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B}" /ve /d "ORM Designer" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\XmlDesigners\{EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B}" /v "Editor" /d "EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\XmlDesigners\{EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B}" /v "Extension" /d "orm" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\XmlDesigners\{EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B}" /v "LogicalView" /d "7651A702-06E5-11D1-8EBD-00A0C90F26EA" /f 1>NUL
		REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRoot%\XmlDesigners\{EDA9E282-8FC6-4AE4-AF2C-C224FD3AE49B}" /v "Namespace" /d "http://schemas.neumont.edu/ORM/2006-04/ORMRoot" /f 1>NUL

		REG ADD "HKLM\SOFTWARE%WOWRegistryAdjust%\Microsoft\.NETFramework\v2.0.50727\AssemblyFoldersEx\NORMAVS" /ve /d "%NORMADir%\bin" /f 1>NUL
		REG ADD "HKLM\SOFTWARE%WOWRegistryAdjust%\Microsoft\.NETFramework\v2.0.50727\AssemblyFoldersEx\NORMAVSExtensions" /ve /d "%NORMADir%\bin\Extensions" /f 1>NUL
	) ELSE (
		CALL:_MakeDir "%VSIXInstallDir%
		XCOPY /Y /D /V /Q "%RootDir%\VSIXInstall\%TargetVisualStudioShortProductName%\extension.vsixmanifest" "%VSIXInstallDir%\"
		XCOPY /Y /D /V /Q "%RootDir%\VSIXInstall\%TargetVisualStudioShortProductName%\ORMDesigner.pkgdef" "%VSIXInstallDir%\"
		XCOPY /Y /D /V /Q "%RootDir%\VSIXInstall\ORMDesignerIcon.png" "%VSIXInstallDir%\"
		XCOPY /Y /D /V /Q "%RootDir%\VSIXInstall\ORMDesignerPreview.png" "%VSIXInstallDir%\"
		XCOPY /Y /D /V /Q "%RootDir%\LICENSE.txt" "%VSIXInstallDir%\"

		IF "%VSInformationSource%"=="Registry" (
			REG ADD "%VSRegistryConfigHive%\%VSRegistryConfigRootBase%\%VSRegistryRootVersion%%VSRegistryRootSuffix%\ExtensionManager\EnabledExtensions" /v "efddc549-1646-4451-8a51-e5a5e94d647c,%ProductMajorVersion%.%ProductMinorVersion%" /d "%VSIXInstallDir%\\" /f 1>NUL
		)
	)

	REG ADD "%DesignerRegistryRoot%\DesignerSettings\Core" /v "SettingsFile" /d "%NORMADir%\Xml\ORMDesignerSettings.xml" /f 1>NUL
	REG ADD "%DesignerRegistryRoot%\DesignerSettings\Core" /v "ConvertersDir" /d "%NORMADir%\Xml\Transforms\Converters\\" /f 1>NUL
	REG ADD "%DesignerRegistryRoot%" /v "VerbalizationDir" /d "%NORMADir%\Xml\Verbalization\\" /f 1>NUL
	REG ADD "%DesignerRegistryRoot%\Extensions\http://schemas.neumont.edu/ORM/2008-11/DiagramDisplay" /v "Class" /d "ORMSolutions.ORMArchitect.Framework.Shell.DiagramDisplayDomainModel" /f 1>NUL

	REG ADD "HKCR\MIME\Database\Content Type\application/orm+xml" /v "Extension" /d ".orm" /f 1>NUL
	REG ADD "HKCR\.orm" /ve /d "ormfile" /f 1>NUL
	REG ADD "HKCR\.orm" /v "Content Type" /d "application/orm+xml" /f 1>NUL
	REG ADD "HKCR\ormfile" /ve /d "Object-Role Modeling File" /f 1>NUL
	REG ADD "HKCR\ormfile\DefaultIcon" /ve /d "%NORMADir%\bin\%TargetBaseName%.dll,0" /f 1>NUL
	REG ADD "HKCR\ormfile\shell\open" /ve /d "&Open" /f 1>NUL
	CALL:_SetShellCommand
	REG ADD "HKCR\ormfile\shell\open\ddeexec" /ve /d "Open(\"%%1\")" /f 1>NUL
	REG ADD "HKCR\ormfile\shell\open\ddeexec\application" /ve /d "VisualStudio.%TargetVisualStudioMajorMinorVersion%" /f 1>NUL
	REG ADD "HKCR\ormfile\shell\open\ddeexec\topic" /ve /d "system" /f 1>NUL

	IF "%VSInformationSource%"=="VSWhere" (
		:: https://visualstudioextensions.vlasovstudio.com/2017/06/29/changing-visual-studio-2017-private-registry-settings/
		:: Register NORMA as an enabled extension so that devenv /setup will pull in the extension settions
		for /d %%f in (%LOCALAPPDATA%\Microsoft\VisualStudio\15.0_*Exp) do (
			reg load HKLM\_TMPVS_%%~nxf "%%f\privateregistry.bin" > NUL
			REG ADD "HKLM\_TMPVS_%%~nxf\Software\Microsoft\VisualStudio\%%~nxf\ExtensionManager\EnabledExtensions" /v "efddc549-1646-4451-8a51-e5a5e94d647c,%ProductMajorVersion%.%ProductMinorVersion%" /d "%VSIXInstallDir%\\" /f 1>NUL
			reg unload HKLM\_TMPVS_%%~nxf > NUL
		)

		ECHO Running 'devenv.exe /RootSuffix "%VSRegistryRootSuffix%" /Setup'... This may take a few minutes...
		CALL "%VSEnvironmentPath%" /RootSuffix "%VSRegistryRootSuffix%" /Setup

		:: Make sure that the devenv process has let go of the rgistry file (the timeout command will not work correctly here due to the process not allowing input redirection... so we have to use the ping "hack")
		ECHO Waiting to make sure devenv.exe has let go of the registry hive...
		:: https://stackoverflow.com/questions/1672338/how-to-sleep-for-5-seconds-in-windowss-command-prompt-or-dos
		ping 127.0.0.1 -n 30 > NUL

		:: https://visualstudioextensions.vlasovstudio.com/2017/06/29/changing-visual-studio-2017-private-registry-settings/
		:: Execute this a second time to make sure that devenv /setup does not disable the extension, sometimes it will due to NORMA depending on Modeling SDK
		for /d %%f in (%LOCALAPPDATA%\Microsoft\VisualStudio\15.0_*Exp) do (
			reg load HKLM\_TMPVS_%%~nxf "%%f\privateregistry.bin" > NUL
			REG ADD "HKLM\_TMPVS_%%~nxf\Software\Microsoft\VisualStudio\%%~nxf\ExtensionManager\EnabledExtensions" /v "efddc549-1646-4451-8a51-e5a5e94d647c,%ProductMajorVersion%.%ProductMinorVersion%" /d "%VSIXInstallDir%\\" /f 1>NUL
			reg unload HKLM\_TMPVS_%%~nxf > NUL
		)
	) ELSE (
		IF /I "%RunDevEnvSetup%"=="True" (ECHO Running 'devenv.exe /RootSuffix "%VSRegistryRootSuffix%" /Setup'... This may take a few minutes... && "%VSEnvironmentPath%" /RootSuffix "%VSRegistryRootSuffix%" /Setup)
	)
)

GOTO:EOF

:_SetShellCommand
::Hack to handle parentheses in environment path
REG ADD "HKCR\ormfile\shell\open\command" /ve /d "\"%VSEnvironmentPath%\" /RootSuffix \"%VSRegistryRootSuffix%\" /dde" /f 1>NUL
GOTO:EOF

:_MakeDir
IF NOT EXIST "%~1" (MKDIR "%~1")
GOTO:EOF

:_MakeDirCopy
IF NOT EXIST "%~1" (
	MKDIR "%~1"
	IF EXIST "%~2" (
		XCOPY /S /Q "%~2" "%~1"
	)
)
GOTO:EOF

:_RemoveDir
IF EXIST "%~1" (RMDIR /S /Q "%~1")
GOTO:EOF

:_CleanupFile
IF EXIST "%~1" (DEL /F /Q "%~1")
GOTO:EOF

:_GenerateVersion
"%RootDir%\VersionGenerator.exe"
GOTO:EOF
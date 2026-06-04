<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kata
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents PanelLeftSidebar As System.Windows.Forms.Panel
    Friend WithEvents PanelRightSidebar As System.Windows.Forms.Panel
    Friend WithEvents PanelMainCenter As System.Windows.Forms.Panel
    Friend WithEvents LblScoringType As System.Windows.Forms.Label
    Friend WithEvents RadScore As System.Windows.Forms.RadioButton
    Friend WithEvents LblRules As System.Windows.Forms.Label
    Friend WithEvents CboRules As System.Windows.Forms.ComboBox
    Friend WithEvents LblMode As System.Windows.Forms.Label
    Friend WithEvents CboMode As System.Windows.Forms.ComboBox
    Friend WithEvents LblManualOnline As System.Windows.Forms.Label
    Friend WithEvents RadFlagSystem As System.Windows.Forms.RadioButton
    Friend WithEvents LblJudgeSelection As System.Windows.Forms.Label
    Friend WithEvents RadJudge5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadJudge7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadJudge3 As System.Windows.Forms.RadioButton
    Friend WithEvents TabRightSettings As System.Windows.Forms.TabControl
    Friend WithEvents PageMatchDetailRight As System.Windows.Forms.TabPage
    Friend WithEvents PageMatchLogoRight As System.Windows.Forms.TabPage
    Friend WithEvents TxtKataCategoryDetail As System.Windows.Forms.TextBox
    Friend WithEvents BtnTextR As System.Windows.Forms.Button
    Friend WithEvents BtnTextMin As System.Windows.Forms.Button
    Friend WithEvents BtnTextPlus As System.Windows.Forms.Button
    Friend WithEvents LblTextAlign As System.Windows.Forms.Label
    Friend WithEvents CboTextAlign As System.Windows.Forms.ComboBox
    Friend WithEvents ChkDetailScore As System.Windows.Forms.CheckBox
    Friend WithEvents BtnDetailScoreUp As System.Windows.Forms.Button
    Friend WithEvents LblTatamiRight As System.Windows.Forms.Label
    Friend WithEvents NumTatamiRight As System.Windows.Forms.NumericUpDown
    Friend WithEvents TxtTimeDisplay As System.Windows.Forms.TextBox
    Friend WithEvents PnlSelectPlayer As System.Windows.Forms.Panel
    Friend WithEvents LblSelectPlayerTitle As System.Windows.Forms.Label
    Friend WithEvents RadCompetitor1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadCompetitor2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllCompetitor As System.Windows.Forms.RadioButton
    Friend WithEvents LblShortcut As System.Windows.Forms.Label
    Friend WithEvents BtnExpand As System.Windows.Forms.Button
    Friend WithEvents BtnStartScoreboardRight As System.Windows.Forms.Button
    Friend WithEvents BtnScore10 As System.Windows.Forms.Button
    Friend WithEvents LblTimerSetting As System.Windows.Forms.Label
    Friend WithEvents LblWaitLabel As System.Windows.Forms.Label
    Friend WithEvents NumWaitMinRight As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblWaitColonRight As System.Windows.Forms.Label
    Friend WithEvents NumWaitSecRight As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPerfLabel As System.Windows.Forms.Label
    Friend WithEvents NumPerfMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPerfColon As System.Windows.Forms.Label
    Friend WithEvents NumPerfSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnStartWaitingTimer As System.Windows.Forms.Button
    Friend WithEvents BtnEye As System.Windows.Forms.Button
    Friend WithEvents BtnSearchWait As System.Windows.Forms.Button
    Friend WithEvents BtnStartTimerRight As System.Windows.Forms.Button
    Friend WithEvents ResetTimer As System.Windows.Forms.Button
    Friend WithEvents StartTimer As System.Windows.Forms.Button
    Friend WithEvents PicMatchLogoRight As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSelectLogoRight As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveLogoRight As System.Windows.Forms.Button
    Friend WithEvents LblJudgeStatusHeader As System.Windows.Forms.Label
    Friend WithEvents LblNextMatch As System.Windows.Forms.Label
    Friend WithEvents TxtAkaNameHeader As System.Windows.Forms.TextBox
    Friend WithEvents BtnAkaIconHeader As System.Windows.Forms.Button
    Friend WithEvents LblVS As System.Windows.Forms.Label
    Friend WithEvents BtnAoIconHeader As System.Windows.Forms.Button
    Friend WithEvents TxtAoNameHeader As System.Windows.Forms.TextBox
    Friend WithEvents BtnSwapHeader As System.Windows.Forms.Button
    Friend WithEvents BtnLoadNextMatch As System.Windows.Forms.Button
    Friend WithEvents PanelAKA As System.Windows.Forms.Panel
    Friend WithEvents LblAkaTitle As System.Windows.Forms.Label
    Friend WithEvents LblAkaName As System.Windows.Forms.Label
    Friend WithEvents BtnAkaUpdateInfo As System.Windows.Forms.Button
    Friend WithEvents BtnAkaUserIcon As System.Windows.Forms.Button
    Friend WithEvents TxtAkaName As System.Windows.Forms.TextBox
    Friend WithEvents LblAkaTeam As System.Windows.Forms.Label
    Friend WithEvents BtnAkaSwapTeam As System.Windows.Forms.Button
    Friend WithEvents BtnAkaSearchTeam As System.Windows.Forms.Button
    Friend WithEvents TxtAkaTeam As System.Windows.Forms.TextBox
    Friend WithEvents TxtAkaTeamInfo As System.Windows.Forms.TextBox
    Friend WithEvents LblAkaKata As System.Windows.Forms.Label
    Friend WithEvents CboAkaKata As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAkaDisqualification As System.Windows.Forms.Button
    Friend WithEvents BtnAkaKiken As System.Windows.Forms.Button
    Friend WithEvents LblAkaCirclePlaceholder As System.Windows.Forms.Label
    Friend WithEvents PicAkaSquarePlaceholder As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAkaShowWinner As System.Windows.Forms.Button
    Friend WithEvents PanelJudgeScore As System.Windows.Forms.Panel
    Friend WithEvents LblJudgeScoreTitle As System.Windows.Forms.Label
    Friend WithEvents PanelAkaScore As System.Windows.Forms.Panel
    Friend WithEvents LblAkaJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAkaJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAkaTotalScore As System.Windows.Forms.Label
    Friend WithEvents NumAkaTotalScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnAkaResetScore As System.Windows.Forms.Button
    Friend WithEvents PanelAoScore As System.Windows.Forms.Panel
    Friend WithEvents LblAoJ1 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ2 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ3 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ4 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoJ5 As System.Windows.Forms.Label
    Friend WithEvents NumAoJ5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblAoTotalScore As System.Windows.Forms.Label
    Friend WithEvents NumAoTotalScore As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnAoResetScore As System.Windows.Forms.Button
    Friend WithEvents PanelAO As System.Windows.Forms.Panel
    Friend WithEvents LblAoTitle As System.Windows.Forms.Label
    Friend WithEvents LblAoName As System.Windows.Forms.Label
    Friend WithEvents BtnAoUpdateInfo As System.Windows.Forms.Button
    Friend WithEvents BtnAoUserIcon As System.Windows.Forms.Button
    Friend WithEvents TxtAoName As System.Windows.Forms.TextBox
    Friend WithEvents LblAoTeam As System.Windows.Forms.Label
    Friend WithEvents BtnAoSwapTeam As System.Windows.Forms.Button
    Friend WithEvents BtnAoSearchTeam As System.Windows.Forms.Button
    Friend WithEvents TxtAoTeam As System.Windows.Forms.TextBox
    Friend WithEvents TxtAoTeamInfo As System.Windows.Forms.TextBox
    Friend WithEvents LblAoKata As System.Windows.Forms.Label
    Friend WithEvents CboAoKata As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAoDisqualification As System.Windows.Forms.Button
    Friend WithEvents BtnAoKiken As System.Windows.Forms.Button
    Friend WithEvents LblAoCirclePlaceholder As System.Windows.Forms.Label
    Friend WithEvents PicAoSquarePlaceholder As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAoShowWinner As System.Windows.Forms.Button
    Friend WithEvents PanelFlagSystem As System.Windows.Forms.Panel
    Friend WithEvents LblFlagSystemTitle As System.Windows.Forms.Label
    Friend WithEvents PanelAkaFlags As System.Windows.Forms.Panel
    Friend WithEvents PanelAoFlags As System.Windows.Forms.Panel
    Friend WithEvents LblAkaFlagTitle As System.Windows.Forms.Label
    Friend WithEvents LblAoFlagTitle As System.Windows.Forms.Label
    Friend WithEvents BtnAkaFlagReset As System.Windows.Forms.Button
    Friend WithEvents BtnAoFlagReset As System.Windows.Forms.Button
    Friend WithEvents LblAkaFlagCount As System.Windows.Forms.Label
    Friend WithEvents LblAoFlagCount As System.Windows.Forms.Label
    ' Panel untuk flag+num AKA
    Friend WithEvents PnlAkaFlagNum1 As System.Windows.Forms.Panel
    Friend WithEvents PnlAkaFlagNum2 As System.Windows.Forms.Panel
    Friend WithEvents PnlAkaFlagNum3 As System.Windows.Forms.Panel
    Friend WithEvents PnlAkaFlagNum4 As System.Windows.Forms.Panel
    Friend WithEvents PnlAkaFlagNum5 As System.Windows.Forms.Panel
    ' Panel untuk flag+num AO
    Friend WithEvents PnlAoFlagNum1 As System.Windows.Forms.Panel
    Friend WithEvents PnlAoFlagNum2 As System.Windows.Forms.Panel
    Friend WithEvents PnlAoFlagNum3 As System.Windows.Forms.Panel
    Friend WithEvents PnlAoFlagNum4 As System.Windows.Forms.Panel
    Friend WithEvents PnlAoFlagNum5 As System.Windows.Forms.Panel
    Friend WithEvents PnlJ1 As System.Windows.Forms.Panel
    Friend WithEvents LblJ1 As System.Windows.Forms.Label
    Friend WithEvents BtnJ1Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ1Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ2 As System.Windows.Forms.Panel
    Friend WithEvents LblJ2 As System.Windows.Forms.Label
    Friend WithEvents BtnJ2Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ2Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ3 As System.Windows.Forms.Panel
    Friend WithEvents LblJ3 As System.Windows.Forms.Label
    Friend WithEvents BtnJ3Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ3Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ4 As System.Windows.Forms.Panel
    Friend WithEvents LblJ4 As System.Windows.Forms.Label
    Friend WithEvents BtnJ4Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ4Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ5 As System.Windows.Forms.Panel
    Friend WithEvents LblJ5 As System.Windows.Forms.Label
    Friend WithEvents BtnJ5Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ5Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ6 As System.Windows.Forms.Panel
    Friend WithEvents LblJ6 As System.Windows.Forms.Label
    Friend WithEvents BtnJ6Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ6Scoring As System.Windows.Forms.Button
    Friend WithEvents PnlJ7 As System.Windows.Forms.Panel
    Friend WithEvents LblJ7 As System.Windows.Forms.Label
    Friend WithEvents BtnJ7Login As System.Windows.Forms.Button
    Friend WithEvents BtnJ7Scoring As System.Windows.Forms.Button
    Friend WithEvents BtnQRCode As System.Windows.Forms.Button
    Friend WithEvents LblApiTimer As System.Windows.Forms.Label
    Friend WithEvents NumApiTimer As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblSec As System.Windows.Forms.Label
    Friend WithEvents BtnAssignTask As System.Windows.Forms.Button
    Friend WithEvents BtnLogActivity As System.Windows.Forms.Button
    Friend WithEvents BtnShortcut As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents BtnSound As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateScore As System.Windows.Forms.Button
    Friend WithEvents BtnShowScore As System.Windows.Forms.Button
    Friend WithEvents BtnResetMatch As System.Windows.Forms.Button
    Friend WithEvents BtnSaveMatch As System.Windows.Forms.Button
    Friend WithEvents PanelAkaFlag6 As System.Windows.Forms.Panel
    Friend WithEvents LblAkaFlag6 As System.Windows.Forms.Label
    Friend WithEvents LblAkaNum6 As System.Windows.Forms.Label
    Friend WithEvents PanelAkaFlag7 As System.Windows.Forms.Panel
    Friend WithEvents LblAkaFlag7 As System.Windows.Forms.Label
    Friend WithEvents LblAkaNum7 As System.Windows.Forms.Label
    Friend WithEvents PanelAoFlag6 As System.Windows.Forms.Panel
    Friend WithEvents LblAoFlag6 As System.Windows.Forms.Label
    Friend WithEvents LblAoNum6 As System.Windows.Forms.Label
    Friend WithEvents PanelAoFlag7 As System.Windows.Forms.Panel
    Friend WithEvents LblAoFlag7 As System.Windows.Forms.Label
    Friend WithEvents LblAoNum7 As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        LblJudgeStatusHeader = New Label()
        LblNextMatch = New Label()
        TxtAkaNameHeader = New TextBox()
        BtnAkaIconHeader = New Button()
        LblVS = New Label()
        BtnAoIconHeader = New Button()
        TxtAoNameHeader = New TextBox()
        BtnSwapHeader = New Button()
        BtnLoadNextMatch = New Button()
        PanelAKA = New Panel()
        LblAkaTitle = New Label()
        LblAkaName = New Label()
        BtnAkaUpdateInfo = New Button()
        BtnAkaUserIcon = New Button()
        TxtAkaName = New TextBox()
        LblAkaTeam = New Label()
        BtnAkaSwapTeam = New Button()
        BtnAkaSearchTeam = New Button()
        TxtAkaTeam = New TextBox()
        TxtAkaTeamInfo = New TextBox()
        LblAkaKata = New Label()
        CboAkaKata = New ComboBox()
        BtnAkaDisqualification = New Button()
        BtnAkaKiken = New Button()
        LblAkaCirclePlaceholder = New Label()
        PicAkaSquarePlaceholder = New PictureBox()
        BtnAkaShowWinner = New Button()
        PanelFooter = New Panel()
        APIInfo = New Button()
        LblApiTimer = New Label()
        NumApiTimer = New NumericUpDown()
        LblSec = New Label()
        BtnAssignTask = New Button()
        BtnLogActivity = New Button()
        BtnShortcut = New Button()
        BtnSettings = New Button()
        BtnDisplay = New Button()
        BtnSound = New Button()
        BtnUpdateScore = New Button()
        BtnShowScore = New Button()
        BtnResetMatch = New Button()
        BtnSaveMatch = New Button()
        PanelLeftSidebar = New Panel()
        PnlJ1 = New Panel()
        LblJ1 = New Label()
        BtnJ1Login = New Button()
        BtnJ1Scoring = New Button()
        PnlJ2 = New Panel()
        LblJ2 = New Label()
        BtnJ2Login = New Button()
        BtnJ2Scoring = New Button()
        PnlJ3 = New Panel()
        LblJ3 = New Label()
        BtnJ3Login = New Button()
        BtnJ3Scoring = New Button()
        PnlJ4 = New Panel()
        LblJ4 = New Label()
        BtnJ4Login = New Button()
        BtnJ4Scoring = New Button()
        PnlJ5 = New Panel()
        LblJ5 = New Label()
        BtnJ5Login = New Button()
        BtnJ5Scoring = New Button()
        PnlJ6 = New Panel()
        LblJ6 = New Label()
        BtnJ6Login = New Button()
        BtnJ6Scoring = New Button()
        PnlJ7 = New Panel()
        LblJ7 = New Label()
        BtnJ7Login = New Button()
        BtnJ7Scoring = New Button()
        BtnQRCode = New Button()
        PanelRightSidebar = New Panel()
        StartTimer = New Button()
        ResetTimer = New Button()
        LblScoringType = New Label()
        RadScore = New RadioButton()
        LblRules = New Label()
        CboRules = New ComboBox()
        LblMode = New Label()
        CboMode = New ComboBox()
        LblManualOnline = New Label()
        RadFlagSystem = New RadioButton()
        LblJudgeSelection = New Label()
        RadJudge5 = New RadioButton()
        RadJudge7 = New RadioButton()
        RadJudge3 = New RadioButton()
        TabRightSettings = New TabControl()
        PageMatchDetailRight = New TabPage()
        TxtKataCategoryDetail = New TextBox()
        BtnTextR = New Button()
        BtnTextMin = New Button()
        BtnTextPlus = New Button()
        LblTextAlign = New Label()
        CboTextAlign = New ComboBox()
        PageMatchLogoRight = New TabPage()
        PicMatchLogoRight = New PictureBox()
        BtnSelectLogoRight = New Button()
        BtnRemoveLogoRight = New Button()
        ChkDetailScore = New CheckBox()
        BtnDetailScoreUp = New Button()
        LblTatamiRight = New Label()
        NumTatamiRight = New NumericUpDown()
        TxtTimeDisplay = New TextBox()
        PnlSelectPlayer = New Panel()
        LblSelectPlayerTitle = New Label()
        RadCompetitor1 = New RadioButton()
        RadCompetitor2 = New RadioButton()
        RadAllCompetitor = New RadioButton()
        LblShortcut = New Label()
        BtnExpand = New Button()
        BtnStartScoreboardRight = New Button()
        BtnScore10 = New Button()
        LblTimerSetting = New Label()
        LblWaitLabel = New Label()
        NumWaitMinRight = New NumericUpDown()
        LblWaitColonRight = New Label()
        NumWaitSecRight = New NumericUpDown()
        LblPerfLabel = New Label()
        NumPerfMin = New NumericUpDown()
        LblPerfColon = New Label()
        NumPerfSec = New NumericUpDown()
        BtnStartWaitingTimer = New Button()
        BtnEye = New Button()
        BtnSearchWait = New Button()
        BtnStartTimerRight = New Button()
        PanelMainCenter = New Panel()
        PanelAO = New Panel()
        LblAoTitle = New Label()
        LblAoName = New Label()
        BtnAoUpdateInfo = New Button()
        BtnAoUserIcon = New Button()
        TxtAoName = New TextBox()
        LblAoTeam = New Label()
        BtnAoSwapTeam = New Button()
        BtnAoSearchTeam = New Button()
        TxtAoTeam = New TextBox()
        TxtAoTeamInfo = New TextBox()
        LblAoKata = New Label()
        CboAoKata = New ComboBox()
        BtnAoDisqualification = New Button()
        BtnAoKiken = New Button()
        LblAoCirclePlaceholder = New Label()
        PicAoSquarePlaceholder = New PictureBox()
        BtnAoShowWinner = New Button()
        PanelJudgeScore = New Panel()
        LblJudgeScoreTitle = New Label()
        PanelAkaScore = New Panel()
        LblAkaJ7 = New Label()
        NumAkaJ7 = New NumericUpDown()
        LblAkaJ6 = New Label()
        NumAkaJ6 = New NumericUpDown()
        LblAkaJ1 = New Label()
        NumAkaJ1 = New NumericUpDown()
        LblAkaJ2 = New Label()
        NumAkaJ2 = New NumericUpDown()
        LblAkaJ3 = New Label()
        NumAkaJ3 = New NumericUpDown()
        LblAkaJ4 = New Label()
        NumAkaJ4 = New NumericUpDown()
        LblAkaJ5 = New Label()
        NumAkaJ5 = New NumericUpDown()
        LblAkaTotalScore = New Label()
        NumAkaTotalScore = New NumericUpDown()
        BtnAkaResetScore = New Button()
        PanelAoScore = New Panel()
        LblAoJ7 = New Label()
        NumAoJ7 = New NumericUpDown()
        LblAoJ6 = New Label()
        NumAoJ6 = New NumericUpDown()
        LblAoJ1 = New Label()
        NumAoJ1 = New NumericUpDown()
        LblAoJ2 = New Label()
        NumAoJ2 = New NumericUpDown()
        LblAoJ3 = New Label()
        NumAoJ3 = New NumericUpDown()
        LblAoJ4 = New Label()
        NumAoJ4 = New NumericUpDown()
        LblAoJ5 = New Label()
        NumAoJ5 = New NumericUpDown()
        LblAoTotalScore = New Label()
        NumAoTotalScore = New NumericUpDown()
        BtnAoResetScore = New Button()
        PanelFlagSystem = New Panel()
        LblFlagSystemTitle = New Label()
        PanelAkaFlags = New Panel()
        PanelAkaFlag4 = New Panel()
        LblAkaFlag4 = New Label()
        LblAkaNum4 = New Label()
        PanelAkaFlag3 = New Panel()
        LblAkaFlag3 = New Label()
        LblAkaNum3 = New Label()
        LblAkaFlagTitle = New Label()
        LblAkaFlagCount = New Label()
        BtnAkaFlagReset = New Button()
        PanelAkaFlag2 = New Panel()
        LblAkaFlag2 = New Label()
        LblAkaNum2 = New Label()
        PanelAkaFlag1 = New Panel()
        LblAkaFlag1 = New Label()
        LblAkaNum1 = New Label()
        PanelAkaFlag5 = New Panel()
        LblAkaFlag5 = New Label()
        LblAkaNum5 = New Label()
        PanelAkaFlag6 = New Panel()
        LblAkaFlag6 = New Label()
        LblAkaNum6 = New Label()
        PanelAkaFlag7 = New Panel()
        LblAkaFlag7 = New Label()
        LblAkaNum7 = New Label()
        PanelAoFlags = New Panel()
        PanelAoFlag4 = New Panel()
        LblAoFlag4 = New Label()
        LblAoNum4 = New Label()
        LblAoFlagTitle = New Label()
        LblAoFlagCount = New Label()
        PanelAoFlag3 = New Panel()
        LblAoFlag3 = New Label()
        LblAoNum3 = New Label()
        BtnAoFlagReset = New Button()
        PanelAoFlag5 = New Panel()
        LblAoFlag5 = New Label()
        LblAoNum5 = New Label()
        PanelAoFlag2 = New Panel()
        LblAoFlag2 = New Label()
        LblAoNum2 = New Label()
        PanelAoFlag1 = New Panel()
        LblAoFlag1 = New Label()
        LblAoNum1 = New Label()
        PanelAoFlag6 = New Panel()
        LblAoFlag6 = New Label()
        LblAoNum6 = New Label()
        PanelAoFlag7 = New Panel()
        LblAoFlag7 = New Label()
        LblAoNum7 = New Label()
        PanelHeader.SuspendLayout()
        PanelAKA.SuspendLayout()
        CType(PicAkaSquarePlaceholder, ComponentModel.ISupportInitialize).BeginInit()
        PanelFooter.SuspendLayout()
        CType(NumApiTimer, ComponentModel.ISupportInitialize).BeginInit()
        PanelLeftSidebar.SuspendLayout()
        PnlJ1.SuspendLayout()
        PnlJ2.SuspendLayout()
        PnlJ3.SuspendLayout()
        PnlJ4.SuspendLayout()
        PnlJ5.SuspendLayout()
        PnlJ6.SuspendLayout()
        PnlJ7.SuspendLayout()
        PanelRightSidebar.SuspendLayout()
        TabRightSettings.SuspendLayout()
        PageMatchDetailRight.SuspendLayout()
        PageMatchLogoRight.SuspendLayout()
        CType(PicMatchLogoRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumTatamiRight, ComponentModel.ISupportInitialize).BeginInit()
        PnlSelectPlayer.SuspendLayout()
        CType(NumWaitMinRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumWaitSecRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumPerfMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumPerfSec, ComponentModel.ISupportInitialize).BeginInit()
        PanelMainCenter.SuspendLayout()
        PanelAO.SuspendLayout()
        CType(PicAoSquarePlaceholder, ComponentModel.ISupportInitialize).BeginInit()
        PanelJudgeScore.SuspendLayout()
        PanelAkaScore.SuspendLayout()
        CType(NumAkaJ7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAkaTotalScore, ComponentModel.ISupportInitialize).BeginInit()
        PanelAoScore.SuspendLayout()
        CType(NumAoJ7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoJ5, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumAoTotalScore, ComponentModel.ISupportInitialize).BeginInit()
        PanelFlagSystem.SuspendLayout()
        PanelAkaFlags.SuspendLayout()
        PanelAkaFlag4.SuspendLayout()
        PanelAkaFlag3.SuspendLayout()
        PanelAkaFlag2.SuspendLayout()
        PanelAkaFlag1.SuspendLayout()
        PanelAkaFlag5.SuspendLayout()
        PanelAkaFlag6.SuspendLayout()
        PanelAkaFlag7.SuspendLayout()
        PanelAoFlags.SuspendLayout()
        PanelAoFlag4.SuspendLayout()
        PanelAoFlag3.SuspendLayout()
        PanelAoFlag5.SuspendLayout()
        PanelAoFlag2.SuspendLayout()
        PanelAoFlag1.SuspendLayout()
        PanelAoFlag6.SuspendLayout()
        PanelAoFlag7.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.LightGray
        PanelHeader.Controls.Add(LblJudgeStatusHeader)
        PanelHeader.Controls.Add(LblNextMatch)
        PanelHeader.Controls.Add(TxtAkaNameHeader)
        PanelHeader.Controls.Add(BtnAkaIconHeader)
        PanelHeader.Controls.Add(LblVS)
        PanelHeader.Controls.Add(BtnAoIconHeader)
        PanelHeader.Controls.Add(TxtAoNameHeader)
        PanelHeader.Controls.Add(BtnSwapHeader)
        PanelHeader.Controls.Add(BtnLoadNextMatch)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1199, 50)
        PanelHeader.TabIndex = 0
        ' 
        ' LblJudgeStatusHeader
        ' 
        LblJudgeStatusHeader.BackColor = Color.MidnightBlue
        LblJudgeStatusHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJudgeStatusHeader.ForeColor = Color.White
        LblJudgeStatusHeader.Location = New Point(0, 0)
        LblJudgeStatusHeader.Name = "LblJudgeStatusHeader"
        LblJudgeStatusHeader.Size = New Size(90, 50)
        LblJudgeStatusHeader.TabIndex = 0
        LblJudgeStatusHeader.Text = "Judge" & vbCrLf & "Status"
        LblJudgeStatusHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblNextMatch
        ' 
        LblNextMatch.BackColor = Color.Gold
        LblNextMatch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblNextMatch.Location = New Point(100, 12)
        LblNextMatch.Name = "LblNextMatch"
        LblNextMatch.Size = New Size(123, 25)
        LblNextMatch.TabIndex = 1
        LblNextMatch.Text = "Next Match"
        LblNextMatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtAkaNameHeader
        ' 
        TxtAkaNameHeader.BorderStyle = BorderStyle.FixedSingle
        TxtAkaNameHeader.Location = New Point(229, 12)
        TxtAkaNameHeader.Name = "TxtAkaNameHeader"
        TxtAkaNameHeader.Size = New Size(197, 23)
        TxtAkaNameHeader.TabIndex = 2
        ' 
        ' BtnAkaIconHeader
        ' 
        BtnAkaIconHeader.BackColor = Color.WhiteSmoke
        BtnAkaIconHeader.FlatStyle = FlatStyle.Flat
        BtnAkaIconHeader.Location = New Point(432, 12)
        BtnAkaIconHeader.Name = "BtnAkaIconHeader"
        BtnAkaIconHeader.Size = New Size(30, 25)
        BtnAkaIconHeader.TabIndex = 3
        BtnAkaIconHeader.Text = "👤"
        BtnAkaIconHeader.UseVisualStyleBackColor = False
        ' 
        ' LblVS
        ' 
        LblVS.BackColor = Color.Gold
        LblVS.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblVS.Location = New Point(468, 12)
        LblVS.Name = "LblVS"
        LblVS.Size = New Size(35, 25)
        LblVS.TabIndex = 4
        LblVS.Text = "VS"
        LblVS.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAoIconHeader
        ' 
        BtnAoIconHeader.BackColor = Color.WhiteSmoke
        BtnAoIconHeader.FlatStyle = FlatStyle.Flat
        BtnAoIconHeader.Location = New Point(509, 13)
        BtnAoIconHeader.Name = "BtnAoIconHeader"
        BtnAoIconHeader.Size = New Size(30, 25)
        BtnAoIconHeader.TabIndex = 5
        BtnAoIconHeader.Text = "👤"
        BtnAoIconHeader.UseVisualStyleBackColor = False
        ' 
        ' TxtAoNameHeader
        ' 
        TxtAoNameHeader.BorderStyle = BorderStyle.FixedSingle
        TxtAoNameHeader.Location = New Point(545, 13)
        TxtAoNameHeader.Name = "TxtAoNameHeader"
        TxtAoNameHeader.Size = New Size(188, 23)
        TxtAoNameHeader.TabIndex = 6
        ' 
        ' BtnSwapHeader
        ' 
        BtnSwapHeader.BackColor = Color.Gray
        BtnSwapHeader.FlatStyle = FlatStyle.Flat
        BtnSwapHeader.ForeColor = Color.White
        BtnSwapHeader.Location = New Point(739, 10)
        BtnSwapHeader.Name = "BtnSwapHeader"
        BtnSwapHeader.Size = New Size(30, 25)
        BtnSwapHeader.TabIndex = 7
        BtnSwapHeader.Text = "⋮⋮"
        BtnSwapHeader.UseVisualStyleBackColor = False
        ' 
        ' BtnLoadNextMatch
        ' 
        BtnLoadNextMatch.BackColor = Color.Gold
        BtnLoadNextMatch.FlatStyle = FlatStyle.Flat
        BtnLoadNextMatch.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnLoadNextMatch.Location = New Point(775, 10)
        BtnLoadNextMatch.Name = "BtnLoadNextMatch"
        BtnLoadNextMatch.Size = New Size(145, 25)
        BtnLoadNextMatch.TabIndex = 8
        BtnLoadNextMatch.Text = "Load Next Match"
        BtnLoadNextMatch.UseVisualStyleBackColor = False
        ' 
        ' PanelAKA
        ' 
        PanelAKA.BorderStyle = BorderStyle.FixedSingle
        PanelAKA.Controls.Add(LblAkaTitle)
        PanelAKA.Controls.Add(LblAkaName)
        PanelAKA.Controls.Add(BtnAkaUpdateInfo)
        PanelAKA.Controls.Add(BtnAkaUserIcon)
        PanelAKA.Controls.Add(TxtAkaName)
        PanelAKA.Controls.Add(LblAkaTeam)
        PanelAKA.Controls.Add(BtnAkaSwapTeam)
        PanelAKA.Controls.Add(BtnAkaSearchTeam)
        PanelAKA.Controls.Add(TxtAkaTeam)
        PanelAKA.Controls.Add(TxtAkaTeamInfo)
        PanelAKA.Controls.Add(LblAkaKata)
        PanelAKA.Controls.Add(CboAkaKata)
        PanelAKA.Controls.Add(BtnAkaDisqualification)
        PanelAKA.Controls.Add(BtnAkaKiken)
        PanelAKA.Controls.Add(LblAkaCirclePlaceholder)
        PanelAKA.Controls.Add(PicAkaSquarePlaceholder)
        PanelAKA.Controls.Add(BtnAkaShowWinner)
        PanelAKA.Dock = DockStyle.Left
        PanelAKA.Location = New Point(0, 0)
        PanelAKA.Name = "PanelAKA"
        PanelAKA.Size = New Size(280, 621)
        PanelAKA.TabIndex = 0
        ' 
        ' LblAkaTitle
        ' 
        LblAkaTitle.BackColor = Color.Crimson
        LblAkaTitle.Dock = DockStyle.Top
        LblAkaTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblAkaTitle.ForeColor = Color.White
        LblAkaTitle.Location = New Point(0, 0)
        LblAkaTitle.Name = "LblAkaTitle"
        LblAkaTitle.Size = New Size(278, 25)
        LblAkaTitle.TabIndex = 0
        LblAkaTitle.Text = "AKA"
        LblAkaTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaName
        ' 
        LblAkaName.AutoSize = True
        LblAkaName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaName.Location = New Point(10, 40)
        LblAkaName.Name = "LblAkaName"
        LblAkaName.Size = New Size(40, 15)
        LblAkaName.TabIndex = 1
        LblAkaName.Text = "Name"
        ' 
        ' BtnAkaUpdateInfo
        ' 
        BtnAkaUpdateInfo.ForeColor = Color.DimGray
        BtnAkaUpdateInfo.Location = New Point(115, 35)
        BtnAkaUpdateInfo.Name = "BtnAkaUpdateInfo"
        BtnAkaUpdateInfo.Size = New Size(120, 25)
        BtnAkaUpdateInfo.TabIndex = 2
        BtnAkaUpdateInfo.Text = "Update Info ⬆"
        BtnAkaUpdateInfo.UseVisualStyleBackColor = True
        ' 
        ' BtnAkaUserIcon
        ' 
        BtnAkaUserIcon.Location = New Point(240, 35)
        BtnAkaUserIcon.Name = "BtnAkaUserIcon"
        BtnAkaUserIcon.Size = New Size(25, 25)
        BtnAkaUserIcon.TabIndex = 3
        BtnAkaUserIcon.Text = "👤"
        BtnAkaUserIcon.UseVisualStyleBackColor = True
        ' 
        ' TxtAkaName
        ' 
        TxtAkaName.Location = New Point(13, 65)
        TxtAkaName.Name = "TxtAkaName"
        TxtAkaName.Size = New Size(252, 23)
        TxtAkaName.TabIndex = 4
        TxtAkaName.Text = "Rizka Amelia"
        ' 
        ' LblAkaTeam
        ' 
        LblAkaTeam.AutoSize = True
        LblAkaTeam.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaTeam.Location = New Point(10, 100)
        LblAkaTeam.Name = "LblAkaTeam"
        LblAkaTeam.Size = New Size(103, 15)
        LblAkaTeam.TabIndex = 5
        LblAkaTeam.Text = "Team | Team Info"
        ' 
        ' BtnAkaSwapTeam
        ' 
        BtnAkaSwapTeam.ForeColor = Color.DodgerBlue
        BtnAkaSwapTeam.Location = New Point(180, 95)
        BtnAkaSwapTeam.Name = "BtnAkaSwapTeam"
        BtnAkaSwapTeam.Size = New Size(55, 25)
        BtnAkaSwapTeam.TabIndex = 6
        BtnAkaSwapTeam.Text = "⇅"
        BtnAkaSwapTeam.UseVisualStyleBackColor = True
        ' 
        ' BtnAkaSearchTeam
        ' 
        BtnAkaSearchTeam.Location = New Point(240, 95)
        BtnAkaSearchTeam.Name = "BtnAkaSearchTeam"
        BtnAkaSearchTeam.Size = New Size(25, 25)
        BtnAkaSearchTeam.TabIndex = 7
        BtnAkaSearchTeam.Text = "🔍"
        BtnAkaSearchTeam.UseVisualStyleBackColor = True
        ' 
        ' TxtAkaTeam
        ' 
        TxtAkaTeam.Location = New Point(13, 125)
        TxtAkaTeam.Name = "TxtAkaTeam"
        TxtAkaTeam.Size = New Size(252, 23)
        TxtAkaTeam.TabIndex = 8
        TxtAkaTeam.Text = "Garuda Sakti"
        ' 
        ' TxtAkaTeamInfo
        ' 
        TxtAkaTeamInfo.Location = New Point(13, 155)
        TxtAkaTeamInfo.Name = "TxtAkaTeamInfo"
        TxtAkaTeamInfo.Size = New Size(252, 23)
        TxtAkaTeamInfo.TabIndex = 9
        TxtAkaTeamInfo.Text = "BKC"
        ' 
        ' LblAkaKata
        ' 
        LblAkaKata.AutoSize = True
        LblAkaKata.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaKata.Location = New Point(10, 190)
        LblAkaKata.Name = "LblAkaKata"
        LblAkaKata.Size = New Size(36, 15)
        LblAkaKata.TabIndex = 10
        LblAkaKata.Text = "KATA"
        ' 
        ' CboAkaKata
        ' 
        CboAkaKata.DropDownStyle = ComboBoxStyle.DropDownList
        CboAkaKata.FormattingEnabled = True
        CboAkaKata.Items.AddRange(New Object() {"Anan - 1", "Anan Dai - 2", "Ananko - 3", "Aoyagi - 4", "Bassai - 5", "Bassai Dai - 6", "Bassai Sho - 7", "Chatanyara Kusanku - 8", "Chibana No Kushanku - 9", "Chinte - 10", "Chinto - 11", "Enpi - 12", "Fukuyugata Ichi - 13", "Fukuyugata Ni - 14", "Gankaku - 15", "Garyu - 16", "Gekisai (Geksai) 1 - 17", "Gekisai (Geksai) 2 - 18", "Gojushiho - 19", "Gojushiho Dai - 20", "Gojushiho Sho - 21", "Hakucho - 22", "Hangetsu - 23", "Haufa (Haffa) - 24", "Heian Shodan - 25", "Heian Nidan - 26", "Heian Sandan - 27", "Heian Yondan - 28", "Heian Godan - 29", "Heiku - 30", "Ishimine Bassai - 31", "Itosu Rohai Shodan - 32", "Itosu Rohai Nidan - 33", "Itosu Rohai Sandan - 34", "Jiin - 35", "Jion - 36", "Jitte - 37", "Juroku - 38", "Kanchin - 39", "Kanku Dai - 40", "Kanku Sho - 41", "Kanshu - 42", "Kishimoto No Kushanku - 43", "Kousoukun - 44", "Kousoukun Dai - 45", "Kousoukun Sho - 46", "Kururunfa - 47", "Kusanku - 48", "Kyan No Chinto - 49", "Kyan No Wanshu - 50", "Matsukaze - 51", "Matsumura Bassai - 52", "Matsumura Rohai - 53", "Meikyo - 54", "Myojo - 55", "Naifanchin Shodan - 56", "Naifanchin Nidan - 57", "Naifanchin Sandan - 58", "Naihanchi - 59", "Nijushiho - 60", "Nipaipo - 61", "Niseishi - 62", "Ohan - 63", "Ohan Dai - 64", "Oyadomari No Passai - 65", "Pachu - 66", "Paiku - 67", "Papuren - 68", "Passai - 69", "Pinan Shodan - 70", "Pinan Nidan - 71", "Pinan Sandan - 72", "Pinan Yondan - 73", "Pinan Godan - 74", "Rohai - 75", "Saifa - 76", "Sanchin - 77", "Sansai - 78", "Sanseiru - 79", "Sanseru - 80", "Seichin - 81", "Seienchin (Seiyunchin) - 82", "Seipai - 83", "Seiryu - 84", "Seishan - 85", "Seisan (Sesan) - 86", "Shiho Kousoukun - 87", "Shinpa - 88", "Shinsei - 89", "Shisochin - 90", "Sochin - 91", "Suparinpei - 92", "Tekki Shodan - 93", "Tekki Nidan - 94", "Tekki Sandan - 95", "Tensho - 96", "Tomari Bassai - 97", "Unshu - 98", "Unsu - 99", "Useishi - 100", "Wankan - 101", "Wanshu - 102"})
        CboAkaKata.Location = New Point(13, 210)
        CboAkaKata.Name = "CboAkaKata"
        CboAkaKata.Size = New Size(252, 23)
        CboAkaKata.TabIndex = 11
        ' 
        ' BtnAkaDisqualification
        ' 
        BtnAkaDisqualification.Location = New Point(13, 250)
        BtnAkaDisqualification.Name = "BtnAkaDisqualification"
        BtnAkaDisqualification.Size = New Size(100, 25)
        BtnAkaDisqualification.TabIndex = 12
        BtnAkaDisqualification.Text = "Disqualification"
        BtnAkaDisqualification.UseVisualStyleBackColor = True
        ' 
        ' BtnAkaKiken
        ' 
        BtnAkaKiken.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnAkaKiken.Location = New Point(13, 285)
        BtnAkaKiken.Name = "BtnAkaKiken"
        BtnAkaKiken.Size = New Size(70, 25)
        BtnAkaKiken.TabIndex = 13
        BtnAkaKiken.Text = "Kiken"
        BtnAkaKiken.UseVisualStyleBackColor = True
        ' 
        ' LblAkaCirclePlaceholder
        ' 
        LblAkaCirclePlaceholder.AutoSize = True
        LblAkaCirclePlaceholder.Font = New Font("Segoe UI", 24.0F)
        LblAkaCirclePlaceholder.ForeColor = Color.MediumOrchid
        LblAkaCirclePlaceholder.Location = New Point(125, 252)
        LblAkaCirclePlaceholder.Name = "LblAkaCirclePlaceholder"
        LblAkaCirclePlaceholder.Size = New Size(56, 45)
        LblAkaCirclePlaceholder.TabIndex = 14
        LblAkaCirclePlaceholder.Text = "◯"
        ' 
        ' PicAkaSquarePlaceholder
        ' 
        PicAkaSquarePlaceholder.BorderStyle = BorderStyle.FixedSingle
        PicAkaSquarePlaceholder.Location = New Point(190, 255)
        PicAkaSquarePlaceholder.Name = "PicAkaSquarePlaceholder"
        PicAkaSquarePlaceholder.Size = New Size(45, 45)
        PicAkaSquarePlaceholder.TabIndex = 15
        PicAkaSquarePlaceholder.TabStop = False
        ' 
        ' BtnAkaShowWinner
        ' 
        BtnAkaShowWinner.Enabled = False
        BtnAkaShowWinner.ForeColor = Color.Gray
        BtnAkaShowWinner.Location = New Point(145, 340)
        BtnAkaShowWinner.Name = "BtnAkaShowWinner"
        BtnAkaShowWinner.Size = New Size(120, 25)
        BtnAkaShowWinner.TabIndex = 16
        BtnAkaShowWinner.Text = "Show Winner 🏆"
        BtnAkaShowWinner.UseVisualStyleBackColor = True
        ' 
        ' PanelFooter
        ' 
        PanelFooter.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(48))
        PanelFooter.Controls.Add(APIInfo)
        PanelFooter.Controls.Add(LblApiTimer)
        PanelFooter.Controls.Add(NumApiTimer)
        PanelFooter.Controls.Add(LblSec)
        PanelFooter.Controls.Add(BtnAssignTask)
        PanelFooter.Controls.Add(BtnLogActivity)
        PanelFooter.Controls.Add(BtnShortcut)
        PanelFooter.Controls.Add(BtnSettings)
        PanelFooter.Controls.Add(BtnDisplay)
        PanelFooter.Controls.Add(BtnSound)
        PanelFooter.Controls.Add(BtnUpdateScore)
        PanelFooter.Controls.Add(BtnShowScore)
        PanelFooter.Controls.Add(BtnResetMatch)
        PanelFooter.Controls.Add(BtnSaveMatch)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 671)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(1199, 50)
        PanelFooter.TabIndex = 1
        ' 
        ' APIInfo
        ' 
        APIInfo.BackColor = Color.White
        APIInfo.FlatStyle = FlatStyle.Flat
        APIInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        APIInfo.Location = New Point(10, 3)
        APIInfo.Name = "APIInfo"
        APIInfo.Size = New Size(70, 42)
        APIInfo.TabIndex = 14
        APIInfo.Text = "API Info"
        APIInfo.UseVisualStyleBackColor = False
        ' 
        ' LblApiTimer
        ' 
        LblApiTimer.AutoSize = True
        LblApiTimer.Font = New Font("Segoe UI", 7.5F)
        LblApiTimer.ForeColor = Color.White
        LblApiTimer.Location = New Point(126, 4)
        LblApiTimer.Name = "LblApiTimer"
        LblApiTimer.Size = New Size(47, 12)
        LblApiTimer.TabIndex = 1
        LblApiTimer.Text = "API Timer"
        ' 
        ' NumApiTimer
        ' 
        NumApiTimer.Location = New Point(120, 16)
        NumApiTimer.Name = "NumApiTimer"
        NumApiTimer.Size = New Size(53, 23)
        NumApiTimer.TabIndex = 2
        NumApiTimer.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' LblSec
        ' 
        LblSec.AutoSize = True
        LblSec.ForeColor = Color.White
        LblSec.Location = New Point(179, 18)
        LblSec.Name = "LblSec"
        LblSec.Size = New Size(12, 15)
        LblSec.TabIndex = 3
        LblSec.Text = "s"
        ' 
        ' BtnAssignTask
        ' 
        BtnAssignTask.BackColor = Color.LightSkyBlue
        BtnAssignTask.FlatStyle = FlatStyle.Flat
        BtnAssignTask.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnAssignTask.Location = New Point(206, 9)
        BtnAssignTask.Name = "BtnAssignTask"
        BtnAssignTask.Size = New Size(160, 30)
        BtnAssignTask.TabIndex = 4
        BtnAssignTask.Text = "Assign Task to Judges " & ChrW(55358) & ChrW(56785) & "‍⚖️"
        BtnAssignTask.UseVisualStyleBackColor = False
        ' 
        ' BtnLogActivity
        ' 
        BtnLogActivity.BackColor = Color.White
        BtnLogActivity.FlatStyle = FlatStyle.Flat
        BtnLogActivity.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnLogActivity.Location = New Point(377, 10)
        BtnLogActivity.Name = "BtnLogActivity"
        BtnLogActivity.Size = New Size(85, 30)
        BtnLogActivity.TabIndex = 5
        BtnLogActivity.Text = "Log Activity"
        BtnLogActivity.UseVisualStyleBackColor = False
        ' 
        ' BtnShortcut
        ' 
        BtnShortcut.BackColor = Color.White
        BtnShortcut.FlatStyle = FlatStyle.Flat
        BtnShortcut.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnShortcut.Location = New Point(468, 9)
        BtnShortcut.Name = "BtnShortcut"
        BtnShortcut.Size = New Size(85, 30)
        BtnShortcut.TabIndex = 6
        BtnShortcut.Text = "Shortcut ⌨"
        BtnShortcut.UseVisualStyleBackColor = False
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackColor = Color.White
        BtnSettings.FlatStyle = FlatStyle.Flat
        BtnSettings.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnSettings.Location = New Point(559, 9)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(117, 30)
        BtnSettings.TabIndex = 7
        BtnSettings.Text = "Settings ⚙"
        BtnSettings.UseVisualStyleBackColor = False
        ' 
        ' BtnDisplay
        ' 
        BtnDisplay.BackColor = Color.White
        BtnDisplay.FlatStyle = FlatStyle.Flat
        BtnDisplay.Location = New Point(682, 9)
        BtnDisplay.Name = "BtnDisplay"
        BtnDisplay.Size = New Size(35, 30)
        BtnDisplay.TabIndex = 8
        BtnDisplay.Text = "🖥"
        BtnDisplay.UseVisualStyleBackColor = False
        ' 
        ' BtnSound
        ' 
        BtnSound.BackColor = Color.White
        BtnSound.FlatStyle = FlatStyle.Flat
        BtnSound.Location = New Point(723, 10)
        BtnSound.Name = "BtnSound"
        BtnSound.Size = New Size(35, 30)
        BtnSound.TabIndex = 9
        BtnSound.Text = "🔊"
        BtnSound.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdateScore
        ' 
        BtnUpdateScore.BackColor = Color.White
        BtnUpdateScore.FlatStyle = FlatStyle.Flat
        BtnUpdateScore.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnUpdateScore.Location = New Point(764, 9)
        BtnUpdateScore.Name = "BtnUpdateScore"
        BtnUpdateScore.Size = New Size(60, 30)
        BtnUpdateScore.TabIndex = 10
        BtnUpdateScore.Text = "Update" & vbCrLf & "Score"
        BtnUpdateScore.UseVisualStyleBackColor = False
        ' 
        ' BtnShowScore
        ' 
        BtnShowScore.BackColor = Color.White
        BtnShowScore.FlatStyle = FlatStyle.Flat
        BtnShowScore.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnShowScore.Location = New Point(830, 10)
        BtnShowScore.Name = "BtnShowScore"
        BtnShowScore.Size = New Size(100, 30)
        BtnShowScore.TabIndex = 11
        BtnShowScore.Text = "Show Score ⬆"
        BtnShowScore.UseVisualStyleBackColor = False
        ' 
        ' BtnResetMatch
        ' 
        BtnResetMatch.BackColor = Color.White
        BtnResetMatch.FlatStyle = FlatStyle.Flat
        BtnResetMatch.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        BtnResetMatch.Location = New Point(940, 10)
        BtnResetMatch.Name = "BtnResetMatch"
        BtnResetMatch.Size = New Size(55, 30)
        BtnResetMatch.TabIndex = 12
        BtnResetMatch.Text = "Reset" & vbCrLf & "Match"
        BtnResetMatch.UseVisualStyleBackColor = False
        ' 
        ' BtnSaveMatch
        ' 
        BtnSaveMatch.BackColor = Color.White
        BtnSaveMatch.FlatStyle = FlatStyle.Flat
        BtnSaveMatch.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        BtnSaveMatch.Location = New Point(1000, 10)
        BtnSaveMatch.Name = "BtnSaveMatch"
        BtnSaveMatch.Size = New Size(180, 30)
        BtnSaveMatch.TabIndex = 13
        BtnSaveMatch.Text = "Save Match Result 💾"
        BtnSaveMatch.UseVisualStyleBackColor = False
        ' 
        ' PanelLeftSidebar
        ' 
        PanelLeftSidebar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        PanelLeftSidebar.Controls.Add(PnlJ1)
        PanelLeftSidebar.Controls.Add(PnlJ2)
        PanelLeftSidebar.Controls.Add(PnlJ3)
        PanelLeftSidebar.Controls.Add(PnlJ4)
        PanelLeftSidebar.Controls.Add(PnlJ5)
        PanelLeftSidebar.Controls.Add(PnlJ6)
        PanelLeftSidebar.Controls.Add(PnlJ7)
        PanelLeftSidebar.Controls.Add(BtnQRCode)
        PanelLeftSidebar.Dock = DockStyle.Left
        PanelLeftSidebar.Location = New Point(0, 50)
        PanelLeftSidebar.Name = "PanelLeftSidebar"
        PanelLeftSidebar.Size = New Size(90, 621)
        PanelLeftSidebar.TabIndex = 2
        ' 
        ' PnlJ1
        ' 
        PnlJ1.BackColor = Color.Black
        PnlJ1.Controls.Add(LblJ1)
        PnlJ1.Controls.Add(BtnJ1Login)
        PnlJ1.Controls.Add(BtnJ1Scoring)
        PnlJ1.Location = New Point(10, 15)
        PnlJ1.Name = "PnlJ1"
        PnlJ1.Size = New Size(70, 68)
        PnlJ1.TabIndex = 0
        ' 
        ' LblJ1
        ' 
        LblJ1.BackColor = Color.Black
        LblJ1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ1.ForeColor = Color.White
        LblJ1.Location = New Point(1, 1)
        LblJ1.Name = "LblJ1"
        LblJ1.Size = New Size(68, 20)
        LblJ1.TabIndex = 0
        LblJ1.Text = "J1"
        LblJ1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ1Login
        ' 
        BtnJ1Login.BackColor = Color.White
        BtnJ1Login.FlatAppearance.BorderSize = 0
        BtnJ1Login.FlatStyle = FlatStyle.Flat
        BtnJ1Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ1Login.Location = New Point(1, 22)
        BtnJ1Login.Name = "BtnJ1Login"
        BtnJ1Login.Size = New Size(68, 22)
        BtnJ1Login.TabIndex = 1
        BtnJ1Login.Text = "Login"
        BtnJ1Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ1Scoring
        ' 
        BtnJ1Scoring.BackColor = Color.White
        BtnJ1Scoring.FlatAppearance.BorderSize = 0
        BtnJ1Scoring.FlatStyle = FlatStyle.Flat
        BtnJ1Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ1Scoring.Location = New Point(1, 45)
        BtnJ1Scoring.Name = "BtnJ1Scoring"
        BtnJ1Scoring.Size = New Size(68, 22)
        BtnJ1Scoring.TabIndex = 2
        BtnJ1Scoring.Text = "Scoring"
        BtnJ1Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ2
        ' 
        PnlJ2.BackColor = Color.Black
        PnlJ2.Controls.Add(LblJ2)
        PnlJ2.Controls.Add(BtnJ2Login)
        PnlJ2.Controls.Add(BtnJ2Scoring)
        PnlJ2.Location = New Point(10, 90)
        PnlJ2.Name = "PnlJ2"
        PnlJ2.Size = New Size(70, 68)
        PnlJ2.TabIndex = 1
        ' 
        ' LblJ2
        ' 
        LblJ2.BackColor = Color.Black
        LblJ2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ2.ForeColor = Color.White
        LblJ2.Location = New Point(1, 1)
        LblJ2.Name = "LblJ2"
        LblJ2.Size = New Size(68, 20)
        LblJ2.TabIndex = 0
        LblJ2.Text = "J2"
        LblJ2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ2Login
        ' 
        BtnJ2Login.BackColor = Color.White
        BtnJ2Login.FlatAppearance.BorderSize = 0
        BtnJ2Login.FlatStyle = FlatStyle.Flat
        BtnJ2Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ2Login.Location = New Point(1, 22)
        BtnJ2Login.Name = "BtnJ2Login"
        BtnJ2Login.Size = New Size(68, 22)
        BtnJ2Login.TabIndex = 1
        BtnJ2Login.Text = "Login"
        BtnJ2Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ2Scoring
        ' 
        BtnJ2Scoring.BackColor = Color.White
        BtnJ2Scoring.FlatAppearance.BorderSize = 0
        BtnJ2Scoring.FlatStyle = FlatStyle.Flat
        BtnJ2Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ2Scoring.Location = New Point(1, 45)
        BtnJ2Scoring.Name = "BtnJ2Scoring"
        BtnJ2Scoring.Size = New Size(68, 22)
        BtnJ2Scoring.TabIndex = 2
        BtnJ2Scoring.Text = "Scoring"
        BtnJ2Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ3
        ' 
        PnlJ3.BackColor = Color.Black
        PnlJ3.Controls.Add(LblJ3)
        PnlJ3.Controls.Add(BtnJ3Login)
        PnlJ3.Controls.Add(BtnJ3Scoring)
        PnlJ3.Location = New Point(10, 165)
        PnlJ3.Name = "PnlJ3"
        PnlJ3.Size = New Size(70, 68)
        PnlJ3.TabIndex = 2
        ' 
        ' LblJ3
        ' 
        LblJ3.BackColor = Color.Black
        LblJ3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ3.ForeColor = Color.White
        LblJ3.Location = New Point(1, 1)
        LblJ3.Name = "LblJ3"
        LblJ3.Size = New Size(68, 20)
        LblJ3.TabIndex = 0
        LblJ3.Text = "J3"
        LblJ3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ3Login
        ' 
        BtnJ3Login.BackColor = Color.White
        BtnJ3Login.FlatAppearance.BorderSize = 0
        BtnJ3Login.FlatStyle = FlatStyle.Flat
        BtnJ3Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ3Login.Location = New Point(1, 22)
        BtnJ3Login.Name = "BtnJ3Login"
        BtnJ3Login.Size = New Size(68, 22)
        BtnJ3Login.TabIndex = 1
        BtnJ3Login.Text = "Login"
        BtnJ3Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ3Scoring
        ' 
        BtnJ3Scoring.BackColor = Color.White
        BtnJ3Scoring.FlatAppearance.BorderSize = 0
        BtnJ3Scoring.FlatStyle = FlatStyle.Flat
        BtnJ3Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ3Scoring.Location = New Point(1, 45)
        BtnJ3Scoring.Name = "BtnJ3Scoring"
        BtnJ3Scoring.Size = New Size(68, 22)
        BtnJ3Scoring.TabIndex = 2
        BtnJ3Scoring.Text = "Scoring"
        BtnJ3Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ4
        ' 
        PnlJ4.BackColor = Color.Black
        PnlJ4.Controls.Add(LblJ4)
        PnlJ4.Controls.Add(BtnJ4Login)
        PnlJ4.Controls.Add(BtnJ4Scoring)
        PnlJ4.Location = New Point(10, 240)
        PnlJ4.Name = "PnlJ4"
        PnlJ4.Size = New Size(70, 68)
        PnlJ4.TabIndex = 3
        ' 
        ' LblJ4
        ' 
        LblJ4.BackColor = Color.Black
        LblJ4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ4.ForeColor = Color.White
        LblJ4.Location = New Point(1, 1)
        LblJ4.Name = "LblJ4"
        LblJ4.Size = New Size(68, 20)
        LblJ4.TabIndex = 0
        LblJ4.Text = "J4"
        LblJ4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ4Login
        ' 
        BtnJ4Login.BackColor = Color.White
        BtnJ4Login.FlatAppearance.BorderSize = 0
        BtnJ4Login.FlatStyle = FlatStyle.Flat
        BtnJ4Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ4Login.Location = New Point(1, 22)
        BtnJ4Login.Name = "BtnJ4Login"
        BtnJ4Login.Size = New Size(68, 22)
        BtnJ4Login.TabIndex = 1
        BtnJ4Login.Text = "Login"
        BtnJ4Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ4Scoring
        ' 
        BtnJ4Scoring.BackColor = Color.White
        BtnJ4Scoring.FlatAppearance.BorderSize = 0
        BtnJ4Scoring.FlatStyle = FlatStyle.Flat
        BtnJ4Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ4Scoring.Location = New Point(1, 45)
        BtnJ4Scoring.Name = "BtnJ4Scoring"
        BtnJ4Scoring.Size = New Size(68, 22)
        BtnJ4Scoring.TabIndex = 2
        BtnJ4Scoring.Text = "Scoring"
        BtnJ4Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ5
        ' 
        PnlJ5.BackColor = Color.Black
        PnlJ5.Controls.Add(LblJ5)
        PnlJ5.Controls.Add(BtnJ5Login)
        PnlJ5.Controls.Add(BtnJ5Scoring)
        PnlJ5.Location = New Point(10, 315)
        PnlJ5.Name = "PnlJ5"
        PnlJ5.Size = New Size(70, 68)
        PnlJ5.TabIndex = 4
        ' 
        ' LblJ5
        ' 
        LblJ5.BackColor = Color.Black
        LblJ5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ5.ForeColor = Color.White
        LblJ5.Location = New Point(1, 1)
        LblJ5.Name = "LblJ5"
        LblJ5.Size = New Size(68, 20)
        LblJ5.TabIndex = 0
        LblJ5.Text = "J5"
        LblJ5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ5Login
        ' 
        BtnJ5Login.BackColor = Color.White
        BtnJ5Login.FlatAppearance.BorderSize = 0
        BtnJ5Login.FlatStyle = FlatStyle.Flat
        BtnJ5Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ5Login.Location = New Point(1, 22)
        BtnJ5Login.Name = "BtnJ5Login"
        BtnJ5Login.Size = New Size(68, 22)
        BtnJ5Login.TabIndex = 1
        BtnJ5Login.Text = "Login"
        BtnJ5Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ5Scoring
        ' 
        BtnJ5Scoring.BackColor = Color.White
        BtnJ5Scoring.FlatAppearance.BorderSize = 0
        BtnJ5Scoring.FlatStyle = FlatStyle.Flat
        BtnJ5Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ5Scoring.Location = New Point(1, 45)
        BtnJ5Scoring.Name = "BtnJ5Scoring"
        BtnJ5Scoring.Size = New Size(68, 22)
        BtnJ5Scoring.TabIndex = 2
        BtnJ5Scoring.Text = "Scoring"
        BtnJ5Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ6
        ' 
        PnlJ6.BackColor = Color.Black
        PnlJ6.Controls.Add(LblJ6)
        PnlJ6.Controls.Add(BtnJ6Login)
        PnlJ6.Controls.Add(BtnJ6Scoring)
        PnlJ6.Location = New Point(10, 390)
        PnlJ6.Name = "PnlJ6"
        PnlJ6.Size = New Size(70, 68)
        PnlJ6.TabIndex = 5
        PnlJ6.Visible = False
        ' 
        ' LblJ6
        ' 
        LblJ6.BackColor = Color.Black
        LblJ6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ6.ForeColor = Color.White
        LblJ6.Location = New Point(1, 1)
        LblJ6.Name = "LblJ6"
        LblJ6.Size = New Size(68, 20)
        LblJ6.TabIndex = 0
        LblJ6.Text = "J6"
        LblJ6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ6Login
        ' 
        BtnJ6Login.BackColor = Color.White
        BtnJ6Login.FlatAppearance.BorderSize = 0
        BtnJ6Login.FlatStyle = FlatStyle.Flat
        BtnJ6Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ6Login.Location = New Point(1, 22)
        BtnJ6Login.Name = "BtnJ6Login"
        BtnJ6Login.Size = New Size(68, 22)
        BtnJ6Login.TabIndex = 1
        BtnJ6Login.Text = "Login"
        BtnJ6Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ6Scoring
        ' 
        BtnJ6Scoring.BackColor = Color.White
        BtnJ6Scoring.FlatAppearance.BorderSize = 0
        BtnJ6Scoring.FlatStyle = FlatStyle.Flat
        BtnJ6Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ6Scoring.Location = New Point(1, 45)
        BtnJ6Scoring.Name = "BtnJ6Scoring"
        BtnJ6Scoring.Size = New Size(68, 22)
        BtnJ6Scoring.TabIndex = 2
        BtnJ6Scoring.Text = "Scoring"
        BtnJ6Scoring.UseVisualStyleBackColor = False
        ' 
        ' PnlJ7
        ' 
        PnlJ7.BackColor = Color.Black
        PnlJ7.Controls.Add(LblJ7)
        PnlJ7.Controls.Add(BtnJ7Login)
        PnlJ7.Controls.Add(BtnJ7Scoring)
        PnlJ7.Location = New Point(10, 465)
        PnlJ7.Name = "PnlJ7"
        PnlJ7.Size = New Size(70, 68)
        PnlJ7.TabIndex = 6
        PnlJ7.Visible = False
        ' 
        ' LblJ7
        ' 
        LblJ7.BackColor = Color.Black
        LblJ7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJ7.ForeColor = Color.White
        LblJ7.Location = New Point(1, 1)
        LblJ7.Name = "LblJ7"
        LblJ7.Size = New Size(68, 20)
        LblJ7.TabIndex = 0
        LblJ7.Text = "J7"
        LblJ7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnJ7Login
        ' 
        BtnJ7Login.BackColor = Color.White
        BtnJ7Login.FlatAppearance.BorderSize = 0
        BtnJ7Login.FlatStyle = FlatStyle.Flat
        BtnJ7Login.Font = New Font("Segoe UI", 7.0F)
        BtnJ7Login.Location = New Point(1, 22)
        BtnJ7Login.Name = "BtnJ7Login"
        BtnJ7Login.Size = New Size(68, 22)
        BtnJ7Login.TabIndex = 1
        BtnJ7Login.Text = "Login"
        BtnJ7Login.UseVisualStyleBackColor = False
        ' 
        ' BtnJ7Scoring
        ' 
        BtnJ7Scoring.BackColor = Color.White
        BtnJ7Scoring.FlatAppearance.BorderSize = 0
        BtnJ7Scoring.FlatStyle = FlatStyle.Flat
        BtnJ7Scoring.Font = New Font("Segoe UI", 7.0F)
        BtnJ7Scoring.Location = New Point(1, 45)
        BtnJ7Scoring.Name = "BtnJ7Scoring"
        BtnJ7Scoring.Size = New Size(68, 22)
        BtnJ7Scoring.TabIndex = 2
        BtnJ7Scoring.Text = "Scoring"
        BtnJ7Scoring.UseVisualStyleBackColor = False
        ' 
        ' BtnQRCode
        ' 
        BtnQRCode.BackColor = Color.White
        BtnQRCode.FlatStyle = FlatStyle.Flat
        BtnQRCode.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnQRCode.Location = New Point(9, 552)
        BtnQRCode.Name = "BtnQRCode"
        BtnQRCode.Size = New Size(70, 42)
        BtnQRCode.TabIndex = 5
        BtnQRCode.Text = "QR" & vbCrLf & "Code"
        BtnQRCode.UseVisualStyleBackColor = False
        ' 
        ' PanelRightSidebar
        ' 
        PanelRightSidebar.BackColor = Color.WhiteSmoke
        PanelRightSidebar.BorderStyle = BorderStyle.FixedSingle
        PanelRightSidebar.Controls.Add(StartTimer)
        PanelRightSidebar.Controls.Add(ResetTimer)
        PanelRightSidebar.Controls.Add(LblScoringType)
        PanelRightSidebar.Controls.Add(RadScore)
        PanelRightSidebar.Controls.Add(LblRules)
        PanelRightSidebar.Controls.Add(CboRules)
        PanelRightSidebar.Controls.Add(LblMode)
        PanelRightSidebar.Controls.Add(CboMode)
        PanelRightSidebar.Controls.Add(LblManualOnline)
        PanelRightSidebar.Controls.Add(RadFlagSystem)
        PanelRightSidebar.Controls.Add(LblJudgeSelection)
        PanelRightSidebar.Controls.Add(RadJudge5)
        PanelRightSidebar.Controls.Add(RadJudge7)
        PanelRightSidebar.Controls.Add(RadJudge3)
        PanelRightSidebar.Controls.Add(TabRightSettings)
        PanelRightSidebar.Controls.Add(ChkDetailScore)
        PanelRightSidebar.Controls.Add(BtnDetailScoreUp)
        PanelRightSidebar.Controls.Add(LblTatamiRight)
        PanelRightSidebar.Controls.Add(NumTatamiRight)
        PanelRightSidebar.Controls.Add(TxtTimeDisplay)
        PanelRightSidebar.Controls.Add(PnlSelectPlayer)
        PanelRightSidebar.Controls.Add(LblTimerSetting)
        PanelRightSidebar.Controls.Add(LblWaitLabel)
        PanelRightSidebar.Controls.Add(NumWaitMinRight)
        PanelRightSidebar.Controls.Add(LblWaitColonRight)
        PanelRightSidebar.Controls.Add(NumWaitSecRight)
        PanelRightSidebar.Controls.Add(LblPerfLabel)
        PanelRightSidebar.Controls.Add(NumPerfMin)
        PanelRightSidebar.Controls.Add(LblPerfColon)
        PanelRightSidebar.Controls.Add(NumPerfSec)
        PanelRightSidebar.Controls.Add(BtnStartWaitingTimer)
        PanelRightSidebar.Controls.Add(BtnEye)
        PanelRightSidebar.Controls.Add(BtnSearchWait)
        PanelRightSidebar.Controls.Add(BtnStartTimerRight)
        PanelRightSidebar.Dock = DockStyle.Right
        PanelRightSidebar.Location = New Point(932, 50)
        PanelRightSidebar.Name = "PanelRightSidebar"
        PanelRightSidebar.Size = New Size(267, 621)
        PanelRightSidebar.TabIndex = 3
        ' 
        ' StartTimer
        ' 
        StartTimer.Location = New Point(190, 560)
        StartTimer.Name = "StartTimer"
        StartTimer.Size = New Size(40, 25)
        StartTimer.TabIndex = 33
        StartTimer.Text = "▶"
        StartTimer.UseVisualStyleBackColor = True
        ' 
        ' ResetTimer
        ' 
        ResetTimer.Location = New Point(145, 560)
        ResetTimer.Name = "ResetTimer"
        ResetTimer.Size = New Size(40, 25)
        ResetTimer.TabIndex = 32
        ResetTimer.Text = "↻"
        ResetTimer.UseVisualStyleBackColor = True
        ' 
        ' LblScoringType
        ' 
        LblScoringType.AutoSize = True
        LblScoringType.Location = New Point(10, 5)
        LblScoringType.Name = "LblScoringType"
        LblScoringType.Size = New Size(75, 15)
        LblScoringType.TabIndex = 0
        LblScoringType.Text = "Scoring Type"
        ' 
        ' RadScore
        ' 
        RadScore.AutoSize = True
        RadScore.Checked = True
        RadScore.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RadScore.Location = New Point(10, 22)
        RadScore.Name = "RadScore"
        RadScore.Size = New Size(57, 19)
        RadScore.TabIndex = 1
        RadScore.TabStop = True
        RadScore.Text = "Score"
        ' 
        ' LblRules
        ' 
        LblRules.AutoSize = True
        LblRules.Location = New Point(10, 48)
        LblRules.Name = "LblRules"
        LblRules.Size = New Size(35, 15)
        LblRules.TabIndex = 2
        LblRules.Text = "Rules"
        ' 
        ' CboRules
        ' 
        CboRules.DropDownStyle = ComboBoxStyle.DropDownList
        CboRules.FormattingEnabled = True
        CboRules.Items.AddRange(New Object() {"Score -> Voting (2026)", "Elimination (2024)"})
        CboRules.Location = New Point(50, 45)
        CboRules.Name = "CboRules"
        CboRules.Size = New Size(205, 23)
        CboRules.TabIndex = 3
        ' 
        ' LblMode
        ' 
        LblMode.AutoSize = True
        LblMode.Location = New Point(10, 78)
        LblMode.Name = "LblMode"
        LblMode.Size = New Size(38, 15)
        LblMode.TabIndex = 4
        LblMode.Text = "Mode"
        ' 
        ' CboMode
        ' 
        CboMode.DropDownStyle = ComboBoxStyle.DropDownList
        CboMode.FormattingEnabled = True
        CboMode.Items.AddRange(New Object() {"Manual", "Online"})
        CboMode.Location = New Point(50, 75)
        CboMode.Name = "CboMode"
        CboMode.Size = New Size(90, 23)
        CboMode.TabIndex = 5
        ' 
        ' LblManualOnline
        ' 
        LblManualOnline.AutoSize = True
        LblManualOnline.Font = New Font("Segoe UI", 8.25F, FontStyle.Underline)
        LblManualOnline.ForeColor = Color.MediumSeaGreen
        LblManualOnline.Location = New Point(145, 78)
        LblManualOnline.Name = "LblManualOnline"
        LblManualOnline.Size = New Size(90, 13)
        LblManualOnline.TabIndex = 6
        LblManualOnline.Text = "Manual | Online"
        ' 
        ' RadFlagSystem
        ' 
        RadFlagSystem.AutoSize = True
        RadFlagSystem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RadFlagSystem.Location = New Point(10, 105)
        RadFlagSystem.Name = "RadFlagSystem"
        RadFlagSystem.Size = New Size(138, 19)
        RadFlagSystem.TabIndex = 7
        RadFlagSystem.Text = "Flag System      🚩 🏴"
        ' 
        ' LblJudgeSelection
        ' 
        LblJudgeSelection.AutoSize = True
        LblJudgeSelection.Location = New Point(10, 130)
        LblJudgeSelection.Name = "LblJudgeSelection"
        LblJudgeSelection.Size = New Size(38, 15)
        LblJudgeSelection.TabIndex = 8
        LblJudgeSelection.Text = "Judge"
        ' 
        ' RadJudge5
        ' 
        RadJudge5.AutoSize = True
        RadJudge5.Checked = True
        RadJudge5.Location = New Point(10, 150)
        RadJudge5.Name = "RadJudge5"
        RadJudge5.Size = New Size(65, 19)
        RadJudge5.TabIndex = 9
        RadJudge5.TabStop = True
        RadJudge5.Text = "5 Judge"
        ' 
        ' RadJudge7
        ' 
        RadJudge7.AutoSize = True
        RadJudge7.Location = New Point(90, 150)
        RadJudge7.Name = "RadJudge7"
        RadJudge7.Size = New Size(65, 19)
        RadJudge7.TabIndex = 10
        RadJudge7.Text = "7 Judge"
        ' 
        ' RadJudge3
        ' 
        RadJudge3.AutoSize = True
        RadJudge3.Location = New Point(170, 150)
        RadJudge3.Name = "RadJudge3"
        RadJudge3.Size = New Size(65, 19)
        RadJudge3.TabIndex = 11
        RadJudge3.Text = "3 Judge"
        ' 
        ' TabRightSettings
        ' 
        TabRightSettings.Controls.Add(PageMatchDetailRight)
        TabRightSettings.Controls.Add(PageMatchLogoRight)
        TabRightSettings.Location = New Point(10, 180)
        TabRightSettings.Name = "TabRightSettings"
        TabRightSettings.SelectedIndex = 0
        TabRightSettings.Size = New Size(245, 115)
        TabRightSettings.TabIndex = 12
        ' 
        ' PageMatchDetailRight
        ' 
        PageMatchDetailRight.Controls.Add(TxtKataCategoryDetail)
        PageMatchDetailRight.Controls.Add(BtnTextR)
        PageMatchDetailRight.Controls.Add(BtnTextMin)
        PageMatchDetailRight.Controls.Add(BtnTextPlus)
        PageMatchDetailRight.Controls.Add(LblTextAlign)
        PageMatchDetailRight.Controls.Add(CboTextAlign)
        PageMatchDetailRight.Location = New Point(4, 24)
        PageMatchDetailRight.Name = "PageMatchDetailRight"
        PageMatchDetailRight.Size = New Size(237, 87)
        PageMatchDetailRight.TabIndex = 0
        PageMatchDetailRight.Text = "Match Detail"
        ' 
        ' TxtKataCategoryDetail
        ' 
        TxtKataCategoryDetail.Location = New Point(5, 5)
        TxtKataCategoryDetail.Multiline = True
        TxtKataCategoryDetail.Name = "TxtKataCategoryDetail"
        TxtKataCategoryDetail.Size = New Size(200, 60)
        TxtKataCategoryDetail.TabIndex = 0
        TxtKataCategoryDetail.Text = "KATA Category Detail"
        ' 
        ' BtnTextR
        ' 
        BtnTextR.Location = New Point(210, 5)
        BtnTextR.Name = "BtnTextR"
        BtnTextR.Size = New Size(25, 20)
        BtnTextR.TabIndex = 1
        BtnTextR.Text = "R"
        ' 
        ' BtnTextMin
        ' 
        BtnTextMin.Location = New Point(210, 27)
        BtnTextMin.Name = "BtnTextMin"
        BtnTextMin.Size = New Size(25, 20)
        BtnTextMin.TabIndex = 2
        BtnTextMin.Text = "-"
        ' 
        ' BtnTextPlus
        ' 
        BtnTextPlus.Location = New Point(210, 49)
        BtnTextPlus.Name = "BtnTextPlus"
        BtnTextPlus.Size = New Size(25, 20)
        BtnTextPlus.TabIndex = 3
        BtnTextPlus.Text = "+"
        ' 
        ' LblTextAlign
        ' 
        LblTextAlign.AutoSize = True
        LblTextAlign.Location = New Point(47, 68)
        LblTextAlign.Name = "LblTextAlign"
        LblTextAlign.Size = New Size(59, 15)
        LblTextAlign.TabIndex = 4
        LblTextAlign.Text = "Text Align"
        ' 
        ' CboTextAlign
        ' 
        CboTextAlign.DropDownStyle = ComboBoxStyle.DropDownList
        CboTextAlign.FormattingEnabled = True
        CboTextAlign.Items.AddRange(New Object() {"Center", "Left", "Right"})
        CboTextAlign.Location = New Point(107, 65)
        CboTextAlign.Name = "CboTextAlign"
        CboTextAlign.Size = New Size(90, 23)
        CboTextAlign.TabIndex = 5
        ' 
        ' PageMatchLogoRight
        ' 
        PageMatchLogoRight.Controls.Add(PicMatchLogoRight)
        PageMatchLogoRight.Controls.Add(BtnSelectLogoRight)
        PageMatchLogoRight.Controls.Add(BtnRemoveLogoRight)
        PageMatchLogoRight.Location = New Point(4, 24)
        PageMatchLogoRight.Name = "PageMatchLogoRight"
        PageMatchLogoRight.Size = New Size(237, 87)
        PageMatchLogoRight.TabIndex = 1
        PageMatchLogoRight.Text = "Match Logo"
        ' 
        ' PicMatchLogoRight
        ' 
        PicMatchLogoRight.BorderStyle = BorderStyle.FixedSingle
        PicMatchLogoRight.Location = New Point(10, 10)
        PicMatchLogoRight.Name = "PicMatchLogoRight"
        PicMatchLogoRight.Size = New Size(65, 65)
        PicMatchLogoRight.SizeMode = PictureBoxSizeMode.Zoom
        PicMatchLogoRight.TabIndex = 0
        PicMatchLogoRight.TabStop = False
        ' 
        ' BtnSelectLogoRight
        ' 
        BtnSelectLogoRight.Location = New Point(85, 10)
        BtnSelectLogoRight.Name = "BtnSelectLogoRight"
        BtnSelectLogoRight.Size = New Size(110, 25)
        BtnSelectLogoRight.TabIndex = 1
        BtnSelectLogoRight.Text = "Select Image..."
        BtnSelectLogoRight.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveLogoRight
        ' 
        BtnRemoveLogoRight.Location = New Point(85, 40)
        BtnRemoveLogoRight.Name = "BtnRemoveLogoRight"
        BtnRemoveLogoRight.Size = New Size(110, 25)
        BtnRemoveLogoRight.TabIndex = 2
        BtnRemoveLogoRight.Text = "Remove..."
        BtnRemoveLogoRight.UseVisualStyleBackColor = True
        ' 
        ' ChkDetailScore
        ' 
        ChkDetailScore.AutoSize = True
        ChkDetailScore.Checked = True
        ChkDetailScore.CheckState = CheckState.Checked
        ChkDetailScore.Enabled = False
        ChkDetailScore.Location = New Point(10, 305)
        ChkDetailScore.Name = "ChkDetailScore"
        ChkDetailScore.Size = New Size(168, 19)
        ChkDetailScore.TabIndex = 13
        ChkDetailScore.Text = "Detail Score on Scoreboard"
        ' 
        ' BtnDetailScoreUp
        ' 
        BtnDetailScoreUp.Location = New Point(230, 300)
        BtnDetailScoreUp.Name = "BtnDetailScoreUp"
        BtnDetailScoreUp.Size = New Size(25, 25)
        BtnDetailScoreUp.TabIndex = 14
        BtnDetailScoreUp.Text = "⬆"
        ' 
        ' LblTatamiRight
        ' 
        LblTatamiRight.AutoSize = True
        LblTatamiRight.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblTatamiRight.Location = New Point(10, 335)
        LblTatamiRight.Name = "LblTatamiRight"
        LblTatamiRight.Size = New Size(75, 19)
        LblTatamiRight.TabIndex = 15
        LblTatamiRight.Text = "T a t a m i"
        ' 
        ' NumTatamiRight
        ' 
        NumTatamiRight.Location = New Point(90, 334)
        NumTatamiRight.Name = "NumTatamiRight"
        NumTatamiRight.Size = New Size(40, 23)
        NumTatamiRight.TabIndex = 16
        NumTatamiRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' TxtTimeDisplay
        ' 
        TxtTimeDisplay.BackColor = Color.LightGray
        TxtTimeDisplay.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        TxtTimeDisplay.Location = New Point(132, 332)
        TxtTimeDisplay.Name = "TxtTimeDisplay"
        TxtTimeDisplay.ReadOnly = True
        TxtTimeDisplay.Size = New Size(123, 25)
        TxtTimeDisplay.TabIndex = 17
        TxtTimeDisplay.Text = "05:00 00"
        TxtTimeDisplay.TextAlign = HorizontalAlignment.Center
        ' 
        ' PnlSelectPlayer
        ' 
        PnlSelectPlayer.BorderStyle = BorderStyle.FixedSingle
        PnlSelectPlayer.Controls.Add(LblSelectPlayerTitle)
        PnlSelectPlayer.Controls.Add(RadCompetitor1)
        PnlSelectPlayer.Controls.Add(RadCompetitor2)
        PnlSelectPlayer.Controls.Add(RadAllCompetitor)
        PnlSelectPlayer.Controls.Add(LblShortcut)
        PnlSelectPlayer.Controls.Add(BtnExpand)
        PnlSelectPlayer.Controls.Add(BtnStartScoreboardRight)
        PnlSelectPlayer.Controls.Add(BtnScore10)
        PnlSelectPlayer.Location = New Point(10, 365)
        PnlSelectPlayer.Name = "PnlSelectPlayer"
        PnlSelectPlayer.Size = New Size(245, 105)
        PnlSelectPlayer.TabIndex = 18
        ' 
        ' LblSelectPlayerTitle
        ' 
        LblSelectPlayerTitle.BackColor = Color.Aquamarine
        LblSelectPlayerTitle.Dock = DockStyle.Top
        LblSelectPlayerTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblSelectPlayerTitle.Location = New Point(0, 0)
        LblSelectPlayerTitle.Name = "LblSelectPlayerTitle"
        LblSelectPlayerTitle.Size = New Size(243, 20)
        LblSelectPlayerTitle.TabIndex = 0
        LblSelectPlayerTitle.Text = "Select Player on Scoreboard"
        LblSelectPlayerTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RadCompetitor1
        ' 
        RadCompetitor1.AutoSize = True
        RadCompetitor1.Checked = True
        RadCompetitor1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RadCompetitor1.ForeColor = Color.Crimson
        RadCompetitor1.Location = New Point(10, 25)
        RadCompetitor1.Name = "RadCompetitor1"
        RadCompetitor1.Size = New Size(99, 19)
        RadCompetitor1.TabIndex = 1
        RadCompetitor1.TabStop = True
        RadCompetitor1.Text = "Competitor 1"
        ' 
        ' RadCompetitor2
        ' 
        RadCompetitor2.AutoSize = True
        RadCompetitor2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RadCompetitor2.ForeColor = Color.MediumBlue
        RadCompetitor2.Location = New Point(10, 48)
        RadCompetitor2.Name = "RadCompetitor2"
        RadCompetitor2.Size = New Size(99, 19)
        RadCompetitor2.TabIndex = 2
        RadCompetitor2.Text = "Competitor 2"
        ' 
        ' RadAllCompetitor
        ' 
        RadAllCompetitor.AutoSize = True
        RadAllCompetitor.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        RadAllCompetitor.Location = New Point(130, 25)
        RadAllCompetitor.Name = "RadAllCompetitor"
        RadAllCompetitor.Size = New Size(106, 19)
        RadAllCompetitor.TabIndex = 3
        RadAllCompetitor.Text = "All Competitor"
        ' 
        ' LblShortcut
        ' 
        LblShortcut.AutoSize = True
        LblShortcut.Font = New Font("Segoe UI", 7.5F)
        LblShortcut.ForeColor = Color.Gray
        LblShortcut.Location = New Point(140, 45)
        LblShortcut.Name = "LblShortcut"
        LblShortcut.Size = New Size(55, 24)
        LblShortcut.TabIndex = 4
        LblShortcut.Text = "Shortcut" & vbCrLf & "Ctrl + 1/2/3"
        LblShortcut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnExpand
        ' 
        BtnExpand.Location = New Point(10, 75)
        BtnExpand.Name = "BtnExpand"
        BtnExpand.Size = New Size(25, 25)
        BtnExpand.TabIndex = 5
        BtnExpand.Text = "⤡"
        ' 
        ' BtnStartScoreboardRight
        ' 
        BtnStartScoreboardRight.BackColor = Color.PaleGreen
        BtnStartScoreboardRight.FlatStyle = FlatStyle.Flat
        BtnStartScoreboardRight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnStartScoreboardRight.Location = New Point(40, 75)
        BtnStartScoreboardRight.Name = "BtnStartScoreboardRight"
        BtnStartScoreboardRight.Size = New Size(160, 25)
        BtnStartScoreboardRight.TabIndex = 6
        BtnStartScoreboardRight.Text = "Start Scoreboard"
        BtnStartScoreboardRight.UseVisualStyleBackColor = False
        ' 
        ' BtnScore10
        ' 
        BtnScore10.Location = New Point(205, 75)
        BtnScore10.Name = "BtnScore10"
        BtnScore10.Size = New Size(30, 25)
        BtnScore10.TabIndex = 7
        BtnScore10.Text = "1:0"
        ' 
        ' LblTimerSetting
        ' 
        LblTimerSetting.AutoSize = True
        LblTimerSetting.Location = New Point(10, 480)
        LblTimerSetting.Name = "LblTimerSetting"
        LblTimerSetting.Size = New Size(168, 15)
        LblTimerSetting.TabIndex = 19
        LblTimerSetting.Text = "Timer Setting (minute:second)"
        ' 
        ' LblWaitLabel
        ' 
        LblWaitLabel.AutoSize = True
        LblWaitLabel.Location = New Point(10, 505)
        LblWaitLabel.Name = "LblWaitLabel"
        LblWaitLabel.Size = New Size(48, 15)
        LblWaitLabel.TabIndex = 20
        LblWaitLabel.Text = "Waiting"
        ' 
        ' NumWaitMinRight
        ' 
        NumWaitMinRight.Location = New Point(130, 503)
        NumWaitMinRight.Name = "NumWaitMinRight"
        NumWaitMinRight.Size = New Size(40, 23)
        NumWaitMinRight.TabIndex = 21
        ' 
        ' LblWaitColonRight
        ' 
        LblWaitColonRight.AutoSize = True
        LblWaitColonRight.Location = New Point(175, 505)
        LblWaitColonRight.Name = "LblWaitColonRight"
        LblWaitColonRight.Size = New Size(10, 15)
        LblWaitColonRight.TabIndex = 22
        LblWaitColonRight.Text = ":"
        ' 
        ' NumWaitSecRight
        ' 
        NumWaitSecRight.Location = New Point(190, 503)
        NumWaitSecRight.Name = "NumWaitSecRight"
        NumWaitSecRight.Size = New Size(40, 23)
        NumWaitSecRight.TabIndex = 23
        NumWaitSecRight.Value = New Decimal(New Integer() {35, 0, 0, 0})
        ' 
        ' LblPerfLabel
        ' 
        LblPerfLabel.AutoSize = True
        LblPerfLabel.Location = New Point(10, 530)
        LblPerfLabel.Name = "LblPerfLabel"
        LblPerfLabel.Size = New Size(75, 15)
        LblPerfLabel.TabIndex = 24
        LblPerfLabel.Text = "Performance"
        ' 
        ' NumPerfMin
        ' 
        NumPerfMin.Location = New Point(130, 528)
        NumPerfMin.Name = "NumPerfMin"
        NumPerfMin.Size = New Size(40, 23)
        NumPerfMin.TabIndex = 25
        NumPerfMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' LblPerfColon
        ' 
        LblPerfColon.AutoSize = True
        LblPerfColon.Location = New Point(175, 530)
        LblPerfColon.Name = "LblPerfColon"
        LblPerfColon.Size = New Size(10, 15)
        LblPerfColon.TabIndex = 26
        LblPerfColon.Text = ":"
        ' 
        ' NumPerfSec
        ' 
        NumPerfSec.Location = New Point(190, 528)
        NumPerfSec.Name = "NumPerfSec"
        NumPerfSec.Size = New Size(40, 23)
        NumPerfSec.TabIndex = 27
        ' 
        ' BtnStartWaitingTimer
        ' 
        BtnStartWaitingTimer.BackColor = Color.PeachPuff
        BtnStartWaitingTimer.FlatStyle = FlatStyle.Flat
        BtnStartWaitingTimer.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnStartWaitingTimer.Location = New Point(10, 560)
        BtnStartWaitingTimer.Name = "BtnStartWaitingTimer"
        BtnStartWaitingTimer.Size = New Size(130, 25)
        BtnStartWaitingTimer.TabIndex = 28
        BtnStartWaitingTimer.Text = "Start Waiting Timer"
        BtnStartWaitingTimer.UseVisualStyleBackColor = False
        ' 
        ' BtnEye
        ' 
        BtnEye.Location = New Point(10, 590)
        BtnEye.Name = "BtnEye"
        BtnEye.Size = New Size(30, 25)
        BtnEye.TabIndex = 29
        BtnEye.Text = "👁"
        ' 
        ' BtnSearchWait
        ' 
        BtnSearchWait.Location = New Point(45, 590)
        BtnSearchWait.Name = "BtnSearchWait"
        BtnSearchWait.Size = New Size(30, 25)
        BtnSearchWait.TabIndex = 30
        BtnSearchWait.Text = "🔍"
        ' 
        ' BtnStartTimerRight
        ' 
        BtnStartTimerRight.BackColor = Color.WhiteSmoke
        BtnStartTimerRight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnStartTimerRight.Location = New Point(80, 590)
        BtnStartTimerRight.Name = "BtnStartTimerRight"
        BtnStartTimerRight.Size = New Size(175, 25)
        BtnStartTimerRight.TabIndex = 31
        BtnStartTimerRight.Text = "Start Timer ⏱"
        BtnStartTimerRight.UseVisualStyleBackColor = False
        ' 
        ' PanelMainCenter
        ' 
        PanelMainCenter.BackColor = Color.White
        PanelMainCenter.Controls.Add(PanelAO)
        PanelMainCenter.Controls.Add(PanelJudgeScore)
        PanelMainCenter.Controls.Add(PanelFlagSystem)
        PanelMainCenter.Controls.Add(PanelAKA)
        PanelMainCenter.Dock = DockStyle.Fill
        PanelMainCenter.Location = New Point(90, 50)
        PanelMainCenter.Name = "PanelMainCenter"
        PanelMainCenter.Size = New Size(842, 621)
        PanelMainCenter.TabIndex = 4
        ' 
        ' PanelAO
        ' 
        PanelAO.BorderStyle = BorderStyle.FixedSingle
        PanelAO.Controls.Add(LblAoTitle)
        PanelAO.Controls.Add(LblAoName)
        PanelAO.Controls.Add(BtnAoUpdateInfo)
        PanelAO.Controls.Add(BtnAoUserIcon)
        PanelAO.Controls.Add(TxtAoName)
        PanelAO.Controls.Add(LblAoTeam)
        PanelAO.Controls.Add(BtnAoSwapTeam)
        PanelAO.Controls.Add(BtnAoSearchTeam)
        PanelAO.Controls.Add(TxtAoTeam)
        PanelAO.Controls.Add(TxtAoTeamInfo)
        PanelAO.Controls.Add(LblAoKata)
        PanelAO.Controls.Add(CboAoKata)
        PanelAO.Controls.Add(BtnAoDisqualification)
        PanelAO.Controls.Add(BtnAoKiken)
        PanelAO.Controls.Add(LblAoCirclePlaceholder)
        PanelAO.Controls.Add(PicAoSquarePlaceholder)
        PanelAO.Controls.Add(BtnAoShowWinner)
        PanelAO.Dock = DockStyle.Fill
        PanelAO.Location = New Point(840, 0)
        PanelAO.Name = "PanelAO"
        PanelAO.Size = New Size(2, 621)
        PanelAO.TabIndex = 2
        ' 
        ' LblAoTitle
        ' 
        LblAoTitle.BackColor = Color.DodgerBlue
        LblAoTitle.Dock = DockStyle.Top
        LblAoTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblAoTitle.ForeColor = Color.White
        LblAoTitle.Location = New Point(0, 0)
        LblAoTitle.Name = "LblAoTitle"
        LblAoTitle.Size = New Size(0, 25)
        LblAoTitle.TabIndex = 0
        LblAoTitle.Text = "AO"
        LblAoTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoName
        ' 
        LblAoName.AutoSize = True
        LblAoName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoName.Location = New Point(10, 40)
        LblAoName.Name = "LblAoName"
        LblAoName.Size = New Size(40, 15)
        LblAoName.TabIndex = 1
        LblAoName.Text = "Name"
        ' 
        ' BtnAoUpdateInfo
        ' 
        BtnAoUpdateInfo.ForeColor = Color.DimGray
        BtnAoUpdateInfo.Location = New Point(115, 35)
        BtnAoUpdateInfo.Name = "BtnAoUpdateInfo"
        BtnAoUpdateInfo.Size = New Size(120, 25)
        BtnAoUpdateInfo.TabIndex = 2
        BtnAoUpdateInfo.Text = "Update Info ⬆"
        BtnAoUpdateInfo.UseVisualStyleBackColor = True
        ' 
        ' BtnAoUserIcon
        ' 
        BtnAoUserIcon.Location = New Point(240, 35)
        BtnAoUserIcon.Name = "BtnAoUserIcon"
        BtnAoUserIcon.Size = New Size(25, 25)
        BtnAoUserIcon.TabIndex = 3
        BtnAoUserIcon.Text = "👤"
        BtnAoUserIcon.UseVisualStyleBackColor = True
        ' 
        ' TxtAoName
        ' 
        TxtAoName.Location = New Point(13, 65)
        TxtAoName.Name = "TxtAoName"
        TxtAoName.Size = New Size(252, 23)
        TxtAoName.TabIndex = 4
        TxtAoName.Text = "Siti Aminah"
        ' 
        ' LblAoTeam
        ' 
        LblAoTeam.AutoSize = True
        LblAoTeam.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoTeam.Location = New Point(10, 100)
        LblAoTeam.Name = "LblAoTeam"
        LblAoTeam.Size = New Size(103, 15)
        LblAoTeam.TabIndex = 5
        LblAoTeam.Text = "Team | Team Info"
        ' 
        ' BtnAoSwapTeam
        ' 
        BtnAoSwapTeam.ForeColor = Color.DodgerBlue
        BtnAoSwapTeam.Location = New Point(180, 95)
        BtnAoSwapTeam.Name = "BtnAoSwapTeam"
        BtnAoSwapTeam.Size = New Size(55, 25)
        BtnAoSwapTeam.TabIndex = 6
        BtnAoSwapTeam.Text = "⇅"
        BtnAoSwapTeam.UseVisualStyleBackColor = True
        ' 
        ' BtnAoSearchTeam
        ' 
        BtnAoSearchTeam.Location = New Point(240, 95)
        BtnAoSearchTeam.Name = "BtnAoSearchTeam"
        BtnAoSearchTeam.Size = New Size(25, 25)
        BtnAoSearchTeam.TabIndex = 7
        BtnAoSearchTeam.Text = "🔍"
        BtnAoSearchTeam.UseVisualStyleBackColor = True
        ' 
        ' TxtAoTeam
        ' 
        TxtAoTeam.Location = New Point(13, 125)
        TxtAoTeam.Name = "TxtAoTeam"
        TxtAoTeam.Size = New Size(252, 23)
        TxtAoTeam.TabIndex = 8
        TxtAoTeam.Text = "Harimau Putih"
        ' 
        ' TxtAoTeamInfo
        ' 
        TxtAoTeamInfo.Location = New Point(13, 155)
        TxtAoTeamInfo.Name = "TxtAoTeamInfo"
        TxtAoTeamInfo.Size = New Size(252, 23)
        TxtAoTeamInfo.TabIndex = 9
        TxtAoTeamInfo.Text = "KKI"
        ' 
        ' LblAoKata
        ' 
        LblAoKata.AutoSize = True
        LblAoKata.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoKata.Location = New Point(10, 190)
        LblAoKata.Name = "LblAoKata"
        LblAoKata.Size = New Size(36, 15)
        LblAoKata.TabIndex = 10
        LblAoKata.Text = "KATA"
        ' 
        ' CboAoKata
        ' 
        CboAoKata.DropDownStyle = ComboBoxStyle.DropDownList
        CboAoKata.FormattingEnabled = True
        CboAoKata.Items.AddRange(New Object() {"Anan - 1", "Anan Dai - 2", "Ananko - 3", "Aoyagi - 4", "Bassai - 5", "Bassai Dai - 6", "Bassai Sho - 7", "Chatanyara Kusanku - 8", "Chibana No Kushanku - 9", "Chinte - 10", "Chinto - 11", "Enpi - 12", "Fukuyugata Ichi - 13", "Fukuyugata Ni - 14", "Gankaku - 15", "Garyu - 16", "Gekisai (Geksai) 1 - 17", "Gekisai (Geksai) 2 - 18", "Gojushiho - 19", "Gojushiho Dai - 20", "Gojushiho Sho - 21", "Hakucho - 22", "Hangetsu - 23", "Haufa (Haffa) - 24", "Heian Shodan - 25", "Heian Nidan - 26", "Heian Sandan - 27", "Heian Yondan - 28", "Heian Godan - 29", "Heiku - 30", "Ishimine Bassai - 31", "Itosu Rohai Shodan - 32", "Itosu Rohai Nidan - 33", "Itosu Rohai Sandan - 34", "Jiin - 35", "Jion - 36", "Jitte - 37", "Juroku - 38", "Kanchin - 39", "Kanku Dai - 40", "Kanku Sho - 41", "Kanshu - 42", "Kishimoto No Kushanku - 43", "Kousoukun - 44", "Kousoukun Dai - 45", "Kousoukun Sho - 46", "Kururunfa - 47", "Kusanku - 48", "Kyan No Chinto - 49", "Kyan No Wanshu - 50", "Matsukaze - 51", "Matsumura Bassai - 52", "Matsumura Rohai - 53", "Meikyo - 54", "Myojo - 55", "Naifanchin Shodan - 56", "Naifanchin Nidan - 57", "Naifanchin Sandan - 58", "Naihanchi - 59", "Nijushiho - 60", "Nipaipo - 61", "Niseishi - 62", "Ohan - 63", "Ohan Dai - 64", "Oyadomari No Passai - 65", "Pachu - 66", "Paiku - 67", "Papuren - 68", "Passai - 69", "Pinan Shodan - 70", "Pinan Nidan - 71", "Pinan Sandan - 72", "Pinan Yondan - 73", "Pinan Godan - 74", "Rohai - 75", "Saifa - 76", "Sanchin - 77", "Sansai - 78", "Sanseiru - 79", "Sanseru - 80", "Seichin - 81", "Seienchin (Seiyunchin) - 82", "Seipai - 83", "Seiryu - 84", "Seishan - 85", "Seisan (Sesan) - 86", "Shiho Kousoukun - 87", "Shinpa - 88", "Shinsei - 89", "Shisochin - 90", "Sochin - 91", "Suparinpei - 92", "Tekki Shodan - 93", "Tekki Nidan - 94", "Tekki Sandan - 95", "Tensho - 96", "Tomari Bassai - 97", "Unshu - 98", "Unsu - 99", "Useishi - 100", "Wankan - 101", "Wanshu - 102"})
        CboAoKata.Location = New Point(13, 210)
        CboAoKata.Name = "CboAoKata"
        CboAoKata.Size = New Size(252, 23)
        CboAoKata.TabIndex = 11
        ' 
        ' BtnAoDisqualification
        ' 
        BtnAoDisqualification.Location = New Point(165, 250)
        BtnAoDisqualification.Name = "BtnAoDisqualification"
        BtnAoDisqualification.Size = New Size(100, 25)
        BtnAoDisqualification.TabIndex = 12
        BtnAoDisqualification.Text = "Disqualification"
        BtnAoDisqualification.UseVisualStyleBackColor = True
        ' 
        ' BtnAoKiken
        ' 
        BtnAoKiken.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnAoKiken.Location = New Point(195, 285)
        BtnAoKiken.Name = "BtnAoKiken"
        BtnAoKiken.Size = New Size(70, 25)
        BtnAoKiken.TabIndex = 13
        BtnAoKiken.Text = "Kiken"
        BtnAoKiken.UseVisualStyleBackColor = True
        ' 
        ' LblAoCirclePlaceholder
        ' 
        LblAoCirclePlaceholder.AutoSize = True
        LblAoCirclePlaceholder.Font = New Font("Segoe UI", 24.0F)
        LblAoCirclePlaceholder.ForeColor = Color.MediumOrchid
        LblAoCirclePlaceholder.Location = New Point(110, 252)
        LblAoCirclePlaceholder.Name = "LblAoCirclePlaceholder"
        LblAoCirclePlaceholder.Size = New Size(56, 45)
        LblAoCirclePlaceholder.TabIndex = 14
        LblAoCirclePlaceholder.Text = "◯"
        ' 
        ' PicAoSquarePlaceholder
        ' 
        PicAoSquarePlaceholder.BorderStyle = BorderStyle.FixedSingle
        PicAoSquarePlaceholder.Location = New Point(50, 255)
        PicAoSquarePlaceholder.Name = "PicAoSquarePlaceholder"
        PicAoSquarePlaceholder.Size = New Size(45, 45)
        PicAoSquarePlaceholder.TabIndex = 15
        PicAoSquarePlaceholder.TabStop = False
        ' 
        ' BtnAoShowWinner
        ' 
        BtnAoShowWinner.Enabled = False
        BtnAoShowWinner.ForeColor = Color.Gray
        BtnAoShowWinner.Location = New Point(15, 340)
        BtnAoShowWinner.Name = "BtnAoShowWinner"
        BtnAoShowWinner.Size = New Size(120, 25)
        BtnAoShowWinner.TabIndex = 16
        BtnAoShowWinner.Text = "Show Winner 🏆"
        BtnAoShowWinner.UseVisualStyleBackColor = True
        ' 
        ' PanelJudgeScore
        ' 
        PanelJudgeScore.Controls.Add(LblJudgeScoreTitle)
        PanelJudgeScore.Controls.Add(PanelAkaScore)
        PanelJudgeScore.Controls.Add(PanelAoScore)
        PanelJudgeScore.Dock = DockStyle.Left
        PanelJudgeScore.Location = New Point(560, 0)
        PanelJudgeScore.Name = "PanelJudgeScore"
        PanelJudgeScore.Size = New Size(280, 621)
        PanelJudgeScore.TabIndex = 1
        ' 
        ' LblJudgeScoreTitle
        ' 
        LblJudgeScoreTitle.Dock = DockStyle.Top
        LblJudgeScoreTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Underline)
        LblJudgeScoreTitle.Location = New Point(0, 0)
        LblJudgeScoreTitle.Name = "LblJudgeScoreTitle"
        LblJudgeScoreTitle.Size = New Size(280, 25)
        LblJudgeScoreTitle.TabIndex = 0
        LblJudgeScoreTitle.Text = "Judge Score"
        LblJudgeScoreTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelAkaScore
        ' 
        PanelAkaScore.BorderStyle = BorderStyle.FixedSingle
        PanelAkaScore.Controls.Add(LblAkaJ7)
        PanelAkaScore.Controls.Add(NumAkaJ7)
        PanelAkaScore.Controls.Add(LblAkaJ6)
        PanelAkaScore.Controls.Add(NumAkaJ6)
        PanelAkaScore.Controls.Add(LblAkaJ1)
        PanelAkaScore.Controls.Add(NumAkaJ1)
        PanelAkaScore.Controls.Add(LblAkaJ2)
        PanelAkaScore.Controls.Add(NumAkaJ2)
        PanelAkaScore.Controls.Add(LblAkaJ3)
        PanelAkaScore.Controls.Add(NumAkaJ3)
        PanelAkaScore.Controls.Add(LblAkaJ4)
        PanelAkaScore.Controls.Add(NumAkaJ4)
        PanelAkaScore.Controls.Add(LblAkaJ5)
        PanelAkaScore.Controls.Add(NumAkaJ5)
        PanelAkaScore.Controls.Add(LblAkaTotalScore)
        PanelAkaScore.Controls.Add(NumAkaTotalScore)
        PanelAkaScore.Controls.Add(BtnAkaResetScore)
        PanelAkaScore.Location = New Point(10, 30)
        PanelAkaScore.Name = "PanelAkaScore"
        PanelAkaScore.Size = New Size(125, 400)
        PanelAkaScore.TabIndex = 1
        ' 
        ' LblAkaJ7
        ' 
        LblAkaJ7.AutoSize = True
        LblAkaJ7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ7.Location = New Point(10, 226)
        LblAkaJ7.Name = "LblAkaJ7"
        LblAkaJ7.Size = New Size(19, 15)
        LblAkaJ7.TabIndex = 15
        LblAkaJ7.Text = "J7"
        ' 
        ' NumAkaJ7
        ' 
        NumAkaJ7.DecimalPlaces = 1
        NumAkaJ7.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ7.Location = New Point(40, 225)
        NumAkaJ7.Name = "NumAkaJ7"
        NumAkaJ7.Size = New Size(70, 27)
        NumAkaJ7.TabIndex = 16
        ' 
        ' LblAkaJ6
        ' 
        LblAkaJ6.AutoSize = True
        LblAkaJ6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ6.Location = New Point(10, 192)
        LblAkaJ6.Name = "LblAkaJ6"
        LblAkaJ6.Size = New Size(19, 15)
        LblAkaJ6.TabIndex = 13
        LblAkaJ6.Text = "J6"
        ' 
        ' NumAkaJ6
        ' 
        NumAkaJ6.DecimalPlaces = 1
        NumAkaJ6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ6.Location = New Point(40, 190)
        NumAkaJ6.Name = "NumAkaJ6"
        NumAkaJ6.Size = New Size(70, 27)
        NumAkaJ6.TabIndex = 14
        ' 
        ' LblAkaJ1
        ' 
        LblAkaJ1.AutoSize = True
        LblAkaJ1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ1.Location = New Point(10, 17)
        LblAkaJ1.Name = "LblAkaJ1"
        LblAkaJ1.Size = New Size(19, 15)
        LblAkaJ1.TabIndex = 0
        LblAkaJ1.Text = "J1"
        ' 
        ' NumAkaJ1
        ' 
        NumAkaJ1.DecimalPlaces = 1
        NumAkaJ1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ1.Location = New Point(40, 15)
        NumAkaJ1.Name = "NumAkaJ1"
        NumAkaJ1.Size = New Size(70, 27)
        NumAkaJ1.TabIndex = 1
        ' 
        ' LblAkaJ2
        ' 
        LblAkaJ2.AutoSize = True
        LblAkaJ2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ2.Location = New Point(10, 52)
        LblAkaJ2.Name = "LblAkaJ2"
        LblAkaJ2.Size = New Size(19, 15)
        LblAkaJ2.TabIndex = 2
        LblAkaJ2.Text = "J2"
        ' 
        ' NumAkaJ2
        ' 
        NumAkaJ2.DecimalPlaces = 1
        NumAkaJ2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ2.Location = New Point(40, 50)
        NumAkaJ2.Name = "NumAkaJ2"
        NumAkaJ2.Size = New Size(70, 27)
        NumAkaJ2.TabIndex = 3
        ' 
        ' LblAkaJ3
        ' 
        LblAkaJ3.AutoSize = True
        LblAkaJ3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ3.Location = New Point(10, 87)
        LblAkaJ3.Name = "LblAkaJ3"
        LblAkaJ3.Size = New Size(19, 15)
        LblAkaJ3.TabIndex = 4
        LblAkaJ3.Text = "J3"
        ' 
        ' NumAkaJ3
        ' 
        NumAkaJ3.DecimalPlaces = 1
        NumAkaJ3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ3.Location = New Point(40, 85)
        NumAkaJ3.Name = "NumAkaJ3"
        NumAkaJ3.Size = New Size(70, 27)
        NumAkaJ3.TabIndex = 5
        ' 
        ' LblAkaJ4
        ' 
        LblAkaJ4.AutoSize = True
        LblAkaJ4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ4.Location = New Point(10, 122)
        LblAkaJ4.Name = "LblAkaJ4"
        LblAkaJ4.Size = New Size(19, 15)
        LblAkaJ4.TabIndex = 6
        LblAkaJ4.Text = "J4"
        ' 
        ' NumAkaJ4
        ' 
        NumAkaJ4.DecimalPlaces = 1
        NumAkaJ4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ4.Location = New Point(40, 120)
        NumAkaJ4.Name = "NumAkaJ4"
        NumAkaJ4.Size = New Size(70, 27)
        NumAkaJ4.TabIndex = 7
        ' 
        ' LblAkaJ5
        ' 
        LblAkaJ5.AutoSize = True
        LblAkaJ5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaJ5.Location = New Point(10, 157)
        LblAkaJ5.Name = "LblAkaJ5"
        LblAkaJ5.Size = New Size(19, 15)
        LblAkaJ5.TabIndex = 8
        LblAkaJ5.Text = "J5"
        ' 
        ' NumAkaJ5
        ' 
        NumAkaJ5.DecimalPlaces = 1
        NumAkaJ5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAkaJ5.Location = New Point(40, 155)
        NumAkaJ5.Name = "NumAkaJ5"
        NumAkaJ5.Size = New Size(70, 27)
        NumAkaJ5.TabIndex = 9
        ' 
        ' LblAkaTotalScore
        ' 
        LblAkaTotalScore.BackColor = Color.DarkOrange
        LblAkaTotalScore.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaTotalScore.Location = New Point(15, 260)
        LblAkaTotalScore.Name = "LblAkaTotalScore"
        LblAkaTotalScore.Size = New Size(93, 20)
        LblAkaTotalScore.TabIndex = 10
        LblAkaTotalScore.Text = "Total Score"
        LblAkaTotalScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAkaTotalScore
        ' 
        NumAkaTotalScore.DecimalPlaces = 1
        NumAkaTotalScore.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        NumAkaTotalScore.Location = New Point(15, 285)
        NumAkaTotalScore.Name = "NumAkaTotalScore"
        NumAkaTotalScore.Size = New Size(93, 50)
        NumAkaTotalScore.TabIndex = 11
        NumAkaTotalScore.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnAkaResetScore
        ' 
        BtnAkaResetScore.Location = New Point(15, 345)
        BtnAkaResetScore.Name = "BtnAkaResetScore"
        BtnAkaResetScore.Size = New Size(93, 25)
        BtnAkaResetScore.TabIndex = 12
        BtnAkaResetScore.Text = "Reset Score"
        ' 
        ' PanelAoScore
        ' 
        PanelAoScore.BorderStyle = BorderStyle.FixedSingle
        PanelAoScore.Controls.Add(LblAoJ7)
        PanelAoScore.Controls.Add(NumAoJ7)
        PanelAoScore.Controls.Add(LblAoJ6)
        PanelAoScore.Controls.Add(NumAoJ6)
        PanelAoScore.Controls.Add(LblAoJ1)
        PanelAoScore.Controls.Add(NumAoJ1)
        PanelAoScore.Controls.Add(LblAoJ2)
        PanelAoScore.Controls.Add(NumAoJ2)
        PanelAoScore.Controls.Add(LblAoJ3)
        PanelAoScore.Controls.Add(NumAoJ3)
        PanelAoScore.Controls.Add(LblAoJ4)
        PanelAoScore.Controls.Add(NumAoJ4)
        PanelAoScore.Controls.Add(LblAoJ5)
        PanelAoScore.Controls.Add(NumAoJ5)
        PanelAoScore.Controls.Add(LblAoTotalScore)
        PanelAoScore.Controls.Add(NumAoTotalScore)
        PanelAoScore.Controls.Add(BtnAoResetScore)
        PanelAoScore.Location = New Point(145, 30)
        PanelAoScore.Name = "PanelAoScore"
        PanelAoScore.Size = New Size(125, 400)
        PanelAoScore.TabIndex = 2
        ' 
        ' LblAoJ7
        ' 
        LblAoJ7.AutoSize = True
        LblAoJ7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ7.Location = New Point(95, 226)
        LblAoJ7.Name = "LblAoJ7"
        LblAoJ7.Size = New Size(19, 15)
        LblAoJ7.TabIndex = 15
        LblAoJ7.Text = "J7"
        ' 
        ' NumAoJ7
        ' 
        NumAoJ7.DecimalPlaces = 1
        NumAoJ7.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ7.Location = New Point(15, 225)
        NumAoJ7.Name = "NumAoJ7"
        NumAoJ7.Size = New Size(70, 27)
        NumAoJ7.TabIndex = 16
        ' 
        ' LblAoJ6
        ' 
        LblAoJ6.AutoSize = True
        LblAoJ6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ6.Location = New Point(95, 192)
        LblAoJ6.Name = "LblAoJ6"
        LblAoJ6.Size = New Size(19, 15)
        LblAoJ6.TabIndex = 13
        LblAoJ6.Text = "J6"
        ' 
        ' NumAoJ6
        ' 
        NumAoJ6.DecimalPlaces = 1
        NumAoJ6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ6.Location = New Point(15, 190)
        NumAoJ6.Name = "NumAoJ6"
        NumAoJ6.Size = New Size(70, 27)
        NumAoJ6.TabIndex = 14
        ' 
        ' LblAoJ1
        ' 
        LblAoJ1.AutoSize = True
        LblAoJ1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ1.Location = New Point(95, 17)
        LblAoJ1.Name = "LblAoJ1"
        LblAoJ1.Size = New Size(19, 15)
        LblAoJ1.TabIndex = 0
        LblAoJ1.Text = "J1"
        ' 
        ' NumAoJ1
        ' 
        NumAoJ1.DecimalPlaces = 1
        NumAoJ1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ1.Location = New Point(15, 15)
        NumAoJ1.Name = "NumAoJ1"
        NumAoJ1.Size = New Size(70, 27)
        NumAoJ1.TabIndex = 1
        ' 
        ' LblAoJ2
        ' 
        LblAoJ2.AutoSize = True
        LblAoJ2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ2.Location = New Point(95, 52)
        LblAoJ2.Name = "LblAoJ2"
        LblAoJ2.Size = New Size(19, 15)
        LblAoJ2.TabIndex = 2
        LblAoJ2.Text = "J2"
        ' 
        ' NumAoJ2
        ' 
        NumAoJ2.DecimalPlaces = 1
        NumAoJ2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ2.Location = New Point(15, 50)
        NumAoJ2.Name = "NumAoJ2"
        NumAoJ2.Size = New Size(70, 27)
        NumAoJ2.TabIndex = 3
        ' 
        ' LblAoJ3
        ' 
        LblAoJ3.AutoSize = True
        LblAoJ3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ3.Location = New Point(95, 87)
        LblAoJ3.Name = "LblAoJ3"
        LblAoJ3.Size = New Size(19, 15)
        LblAoJ3.TabIndex = 4
        LblAoJ3.Text = "J3"
        ' 
        ' NumAoJ3
        ' 
        NumAoJ3.DecimalPlaces = 1
        NumAoJ3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ3.Location = New Point(15, 85)
        NumAoJ3.Name = "NumAoJ3"
        NumAoJ3.Size = New Size(70, 27)
        NumAoJ3.TabIndex = 5
        ' 
        ' LblAoJ4
        ' 
        LblAoJ4.AutoSize = True
        LblAoJ4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ4.Location = New Point(95, 122)
        LblAoJ4.Name = "LblAoJ4"
        LblAoJ4.Size = New Size(19, 15)
        LblAoJ4.TabIndex = 6
        LblAoJ4.Text = "J4"
        ' 
        ' NumAoJ4
        ' 
        NumAoJ4.DecimalPlaces = 1
        NumAoJ4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ4.Location = New Point(15, 120)
        NumAoJ4.Name = "NumAoJ4"
        NumAoJ4.Size = New Size(70, 27)
        NumAoJ4.TabIndex = 7
        ' 
        ' LblAoJ5
        ' 
        LblAoJ5.AutoSize = True
        LblAoJ5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoJ5.Location = New Point(95, 157)
        LblAoJ5.Name = "LblAoJ5"
        LblAoJ5.Size = New Size(19, 15)
        LblAoJ5.TabIndex = 8
        LblAoJ5.Text = "J5"
        ' 
        ' NumAoJ5
        ' 
        NumAoJ5.DecimalPlaces = 1
        NumAoJ5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        NumAoJ5.Location = New Point(15, 155)
        NumAoJ5.Name = "NumAoJ5"
        NumAoJ5.Size = New Size(70, 27)
        NumAoJ5.TabIndex = 9
        ' 
        ' LblAoTotalScore
        ' 
        LblAoTotalScore.BackColor = Color.DarkOrange
        LblAoTotalScore.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoTotalScore.Location = New Point(15, 260)
        LblAoTotalScore.Name = "LblAoTotalScore"
        LblAoTotalScore.Size = New Size(93, 20)
        LblAoTotalScore.TabIndex = 10
        LblAoTotalScore.Text = "Total Score"
        LblAoTotalScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NumAoTotalScore
        ' 
        NumAoTotalScore.DecimalPlaces = 1
        NumAoTotalScore.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        NumAoTotalScore.Location = New Point(15, 285)
        NumAoTotalScore.Name = "NumAoTotalScore"
        NumAoTotalScore.Size = New Size(93, 50)
        NumAoTotalScore.TabIndex = 11
        NumAoTotalScore.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnAoResetScore
        ' 
        BtnAoResetScore.Location = New Point(15, 345)
        BtnAoResetScore.Name = "BtnAoResetScore"
        BtnAoResetScore.Size = New Size(93, 25)
        BtnAoResetScore.TabIndex = 12
        BtnAoResetScore.Text = "Reset Score"
        ' 
        ' PanelFlagSystem
        ' 
        PanelFlagSystem.Controls.Add(LblFlagSystemTitle)
        PanelFlagSystem.Controls.Add(PanelAkaFlags)
        PanelFlagSystem.Controls.Add(PanelAoFlags)
        PanelFlagSystem.Dock = DockStyle.Left
        PanelFlagSystem.Location = New Point(280, 0)
        PanelFlagSystem.Name = "PanelFlagSystem"
        PanelFlagSystem.Size = New Size(280, 621)
        PanelFlagSystem.TabIndex = 5
        PanelFlagSystem.Visible = False
        ' 
        ' LblFlagSystemTitle
        ' 
        LblFlagSystemTitle.Dock = DockStyle.Top
        LblFlagSystemTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Underline)
        LblFlagSystemTitle.Location = New Point(0, 0)
        LblFlagSystemTitle.Name = "LblFlagSystemTitle"
        LblFlagSystemTitle.Size = New Size(280, 25)
        LblFlagSystemTitle.TabIndex = 0
        LblFlagSystemTitle.Text = "Flag System Voting"
        LblFlagSystemTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelAkaFlags
        ' 
        PanelAkaFlags.BorderStyle = BorderStyle.FixedSingle
        PanelAkaFlags.Controls.Add(PanelAkaFlag4)
        PanelAkaFlags.Controls.Add(PanelAkaFlag3)
        PanelAkaFlags.Controls.Add(LblAkaFlagTitle)
        PanelAkaFlags.Controls.Add(LblAkaFlagCount)
        PanelAkaFlags.Controls.Add(BtnAkaFlagReset)
        PanelAkaFlags.Controls.Add(PanelAkaFlag2)
        PanelAkaFlags.Controls.Add(PanelAkaFlag1)
        PanelAkaFlags.Controls.Add(PanelAkaFlag5)
        PanelAkaFlags.Controls.Add(PanelAkaFlag6)
        PanelAkaFlags.Controls.Add(PanelAkaFlag7)
        PanelAkaFlags.Location = New Point(10, 30)
        PanelAkaFlags.Name = "PanelAkaFlags"
        PanelAkaFlags.Size = New Size(125, 400)
        PanelAkaFlags.TabIndex = 1
        ' 
        ' PanelAkaFlag4
        ' 
        PanelAkaFlag4.Controls.Add(LblAkaFlag4)
        PanelAkaFlag4.Controls.Add(LblAkaNum4)
        PanelAkaFlag4.Location = New Point(15, 115)
        PanelAkaFlag4.Name = "PanelAkaFlag4"
        PanelAkaFlag4.Size = New Size(93, 34)
        PanelAkaFlag4.TabIndex = 17
        ' 
        ' LblAkaFlag4
        ' 
        LblAkaFlag4.AutoSize = True
        LblAkaFlag4.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag4.Location = New Point(10, 7)
        LblAkaFlag4.Name = "LblAkaFlag4"
        LblAkaFlag4.Size = New Size(32, 21)
        LblAkaFlag4.TabIndex = 6
        LblAkaFlag4.Text = "🚩"
        ' 
        ' LblAkaNum4
        ' 
        LblAkaNum4.AutoSize = True
        LblAkaNum4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum4.Location = New Point(60, 7)
        LblAkaNum4.Name = "LblAkaNum4"
        LblAkaNum4.Size = New Size(19, 21)
        LblAkaNum4.TabIndex = 5
        LblAkaNum4.Text = "4"
        ' 
        ' PanelAkaFlag3
        ' 
        PanelAkaFlag3.Controls.Add(LblAkaFlag3)
        PanelAkaFlag3.Controls.Add(LblAkaNum3)
        PanelAkaFlag3.Location = New Point(15, 150)
        PanelAkaFlag3.Name = "PanelAkaFlag3"
        PanelAkaFlag3.Size = New Size(93, 34)
        PanelAkaFlag3.TabIndex = 16
        ' 
        ' LblAkaFlag3
        ' 
        LblAkaFlag3.AutoSize = True
        LblAkaFlag3.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag3.Location = New Point(10, 7)
        LblAkaFlag3.Name = "LblAkaFlag3"
        LblAkaFlag3.Size = New Size(32, 21)
        LblAkaFlag3.TabIndex = 6
        LblAkaFlag3.Text = "🚩"
        ' 
        ' LblAkaNum3
        ' 
        LblAkaNum3.AutoSize = True
        LblAkaNum3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum3.Location = New Point(60, 7)
        LblAkaNum3.Name = "LblAkaNum3"
        LblAkaNum3.Size = New Size(19, 21)
        LblAkaNum3.TabIndex = 5
        LblAkaNum3.Text = "3"
        ' 
        ' LblAkaFlagTitle
        ' 
        LblAkaFlagTitle.BackColor = Color.Crimson
        LblAkaFlagTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAkaFlagTitle.ForeColor = Color.White
        LblAkaFlagTitle.Location = New Point(15, 260)
        LblAkaFlagTitle.Name = "LblAkaFlagTitle"
        LblAkaFlagTitle.Size = New Size(93, 20)
        LblAkaFlagTitle.TabIndex = 0
        LblAkaFlagTitle.Text = "Total Flags"
        LblAkaFlagTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAkaFlagCount
        ' 
        LblAkaFlagCount.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        LblAkaFlagCount.Location = New Point(15, 285)
        LblAkaFlagCount.Name = "LblAkaFlagCount"
        LblAkaFlagCount.Size = New Size(93, 50)
        LblAkaFlagCount.TabIndex = 1
        LblAkaFlagCount.Text = "0"
        LblAkaFlagCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAkaFlagReset
        ' 
        BtnAkaFlagReset.Location = New Point(15, 345)
        BtnAkaFlagReset.Name = "BtnAkaFlagReset"
        BtnAkaFlagReset.Size = New Size(93, 25)
        BtnAkaFlagReset.TabIndex = 2
        BtnAkaFlagReset.Text = "Reset Flag"
        ' 
        ' PanelAkaFlag2
        ' 
        PanelAkaFlag2.Controls.Add(LblAkaFlag2)
        PanelAkaFlag2.Controls.Add(LblAkaNum2)
        PanelAkaFlag2.Location = New Point(15, 185)
        PanelAkaFlag2.Name = "PanelAkaFlag2"
        PanelAkaFlag2.Size = New Size(93, 34)
        PanelAkaFlag2.TabIndex = 15
        ' 
        ' LblAkaFlag2
        ' 
        LblAkaFlag2.AutoSize = True
        LblAkaFlag2.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag2.Location = New Point(10, 7)
        LblAkaFlag2.Name = "LblAkaFlag2"
        LblAkaFlag2.Size = New Size(32, 21)
        LblAkaFlag2.TabIndex = 6
        LblAkaFlag2.Text = "🚩"
        ' 
        ' LblAkaNum2
        ' 
        LblAkaNum2.AutoSize = True
        LblAkaNum2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum2.Location = New Point(60, 7)
        LblAkaNum2.Name = "LblAkaNum2"
        LblAkaNum2.Size = New Size(19, 21)
        LblAkaNum2.TabIndex = 5
        LblAkaNum2.Text = "2"
        ' 
        ' PanelAkaFlag1
        ' 
        PanelAkaFlag1.Controls.Add(LblAkaFlag1)
        PanelAkaFlag1.Controls.Add(LblAkaNum1)
        PanelAkaFlag1.Location = New Point(15, 220)
        PanelAkaFlag1.Name = "PanelAkaFlag1"
        PanelAkaFlag1.Size = New Size(93, 34)
        PanelAkaFlag1.TabIndex = 14
        ' 
        ' LblAkaFlag1
        ' 
        LblAkaFlag1.AutoSize = True
        LblAkaFlag1.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag1.Location = New Point(10, 7)
        LblAkaFlag1.Name = "LblAkaFlag1"
        LblAkaFlag1.Size = New Size(32, 21)
        LblAkaFlag1.TabIndex = 6
        LblAkaFlag1.Text = "🚩"
        ' 
        ' LblAkaNum1
        ' 
        LblAkaNum1.AutoSize = True
        LblAkaNum1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum1.Location = New Point(60, 7)
        LblAkaNum1.Name = "LblAkaNum1"
        LblAkaNum1.Size = New Size(19, 21)
        LblAkaNum1.TabIndex = 5
        LblAkaNum1.Text = "1"
        ' 
        ' PanelAkaFlag5
        ' 
        PanelAkaFlag5.Controls.Add(LblAkaFlag5)
        PanelAkaFlag5.Controls.Add(LblAkaNum5)
        PanelAkaFlag5.Location = New Point(15, 80)
        PanelAkaFlag5.Name = "PanelAkaFlag5"
        PanelAkaFlag5.Size = New Size(93, 34)
        PanelAkaFlag5.TabIndex = 13
        ' 
        ' LblAkaFlag5
        ' 
        LblAkaFlag5.AutoSize = True
        LblAkaFlag5.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag5.Location = New Point(10, 7)
        LblAkaFlag5.Name = "LblAkaFlag5"
        LblAkaFlag5.Size = New Size(32, 21)
        LblAkaFlag5.TabIndex = 6
        LblAkaFlag5.Text = "🚩"
        ' 
        ' LblAkaNum5
        ' 
        LblAkaNum5.AutoSize = True
        LblAkaNum5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum5.Location = New Point(60, 7)
        LblAkaNum5.Name = "LblAkaNum5"
        LblAkaNum5.Size = New Size(19, 21)
        LblAkaNum5.TabIndex = 5
        LblAkaNum5.Text = "5"
        ' 
        ' PanelAkaFlag6
        ' 
        PanelAkaFlag6.Controls.Add(LblAkaFlag6)
        PanelAkaFlag6.Controls.Add(LblAkaNum6)
        PanelAkaFlag6.Location = New Point(15, 44)
        PanelAkaFlag6.Name = "PanelAkaFlag6"
        PanelAkaFlag6.Size = New Size(93, 34)
        PanelAkaFlag6.TabIndex = 25
        PanelAkaFlag6.Visible = False
        ' 
        ' LblAkaFlag6
        ' 
        LblAkaFlag6.AutoSize = True
        LblAkaFlag6.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag6.Location = New Point(10, 7)
        LblAkaFlag6.Name = "LblAkaFlag6"
        LblAkaFlag6.Size = New Size(32, 21)
        LblAkaFlag6.TabIndex = 6
        LblAkaFlag6.Text = "🚩"
        ' 
        ' LblAkaNum6
        ' 
        LblAkaNum6.AutoSize = True
        LblAkaNum6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum6.Location = New Point(60, 7)
        LblAkaNum6.Name = "LblAkaNum6"
        LblAkaNum6.Size = New Size(19, 21)
        LblAkaNum6.TabIndex = 5
        LblAkaNum6.Text = "6"
        ' 
        ' PanelAkaFlag7
        ' 
        PanelAkaFlag7.Controls.Add(LblAkaFlag7)
        PanelAkaFlag7.Controls.Add(LblAkaNum7)
        PanelAkaFlag7.Location = New Point(15, 9)
        PanelAkaFlag7.Name = "PanelAkaFlag7"
        PanelAkaFlag7.Size = New Size(93, 34)
        PanelAkaFlag7.TabIndex = 26
        PanelAkaFlag7.Visible = False
        ' 
        ' LblAkaFlag7
        ' 
        LblAkaFlag7.AutoSize = True
        LblAkaFlag7.Font = New Font("Segoe UI", 12.0F)
        LblAkaFlag7.Location = New Point(10, 7)
        LblAkaFlag7.Name = "LblAkaFlag7"
        LblAkaFlag7.Size = New Size(32, 21)
        LblAkaFlag7.TabIndex = 6
        LblAkaFlag7.Text = "🚩"
        ' 
        ' LblAkaNum7
        ' 
        LblAkaNum7.AutoSize = True
        LblAkaNum7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAkaNum7.Location = New Point(60, 7)
        LblAkaNum7.Name = "LblAkaNum7"
        LblAkaNum7.Size = New Size(19, 21)
        LblAkaNum7.TabIndex = 5
        LblAkaNum7.Text = "7"
        ' 
        ' PanelAoFlags
        ' 
        PanelAoFlags.BorderStyle = BorderStyle.FixedSingle
        PanelAoFlags.Controls.Add(PanelAoFlag4)
        PanelAoFlags.Controls.Add(LblAoFlagTitle)
        PanelAoFlags.Controls.Add(LblAoFlagCount)
        PanelAoFlags.Controls.Add(PanelAoFlag3)
        PanelAoFlags.Controls.Add(BtnAoFlagReset)
        PanelAoFlags.Controls.Add(PanelAoFlag5)
        PanelAoFlags.Controls.Add(PanelAoFlag2)
        PanelAoFlags.Controls.Add(PanelAoFlag1)
        PanelAoFlags.Controls.Add(PanelAoFlag6)
        PanelAoFlags.Controls.Add(PanelAoFlag7)
        PanelAoFlags.Location = New Point(145, 30)
        PanelAoFlags.Name = "PanelAoFlags"
        PanelAoFlags.Size = New Size(125, 400)
        PanelAoFlags.TabIndex = 2
        ' 
        ' PanelAoFlag4
        ' 
        PanelAoFlag4.Controls.Add(LblAoFlag4)
        PanelAoFlag4.Controls.Add(LblAoNum4)
        PanelAoFlag4.Location = New Point(15, 115)
        PanelAoFlag4.Name = "PanelAoFlag4"
        PanelAoFlag4.Size = New Size(93, 34)
        PanelAoFlag4.TabIndex = 22
        ' 
        ' LblAoFlag4
        ' 
        LblAoFlag4.AutoSize = True
        LblAoFlag4.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag4.Location = New Point(10, 7)
        LblAoFlag4.Name = "LblAoFlag4"
        LblAoFlag4.Size = New Size(32, 21)
        LblAoFlag4.TabIndex = 6
        LblAoFlag4.Text = "🚩"
        ' 
        ' LblAoNum4
        ' 
        LblAoNum4.AutoSize = True
        LblAoNum4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum4.Location = New Point(60, 7)
        LblAoNum4.Name = "LblAoNum4"
        LblAoNum4.Size = New Size(19, 21)
        LblAoNum4.TabIndex = 5
        LblAoNum4.Text = "4"
        ' 
        ' LblAoFlagTitle
        ' 
        LblAoFlagTitle.BackColor = Color.DodgerBlue
        LblAoFlagTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblAoFlagTitle.ForeColor = Color.White
        LblAoFlagTitle.Location = New Point(15, 260)
        LblAoFlagTitle.Name = "LblAoFlagTitle"
        LblAoFlagTitle.Size = New Size(93, 20)
        LblAoFlagTitle.TabIndex = 0
        LblAoFlagTitle.Text = "Total Flags"
        LblAoFlagTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAoFlagCount
        ' 
        LblAoFlagCount.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        LblAoFlagCount.Location = New Point(15, 285)
        LblAoFlagCount.Name = "LblAoFlagCount"
        LblAoFlagCount.Size = New Size(93, 50)
        LblAoFlagCount.TabIndex = 1
        LblAoFlagCount.Text = "0"
        LblAoFlagCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelAoFlag3
        ' 
        PanelAoFlag3.Controls.Add(LblAoFlag3)
        PanelAoFlag3.Controls.Add(LblAoNum3)
        PanelAoFlag3.Location = New Point(15, 150)
        PanelAoFlag3.Name = "PanelAoFlag3"
        PanelAoFlag3.Size = New Size(93, 34)
        PanelAoFlag3.TabIndex = 21
        ' 
        ' LblAoFlag3
        ' 
        LblAoFlag3.AutoSize = True
        LblAoFlag3.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag3.Location = New Point(10, 7)
        LblAoFlag3.Name = "LblAoFlag3"
        LblAoFlag3.Size = New Size(32, 21)
        LblAoFlag3.TabIndex = 6
        LblAoFlag3.Text = "🚩"
        ' 
        ' LblAoNum3
        ' 
        LblAoNum3.AutoSize = True
        LblAoNum3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum3.Location = New Point(60, 7)
        LblAoNum3.Name = "LblAoNum3"
        LblAoNum3.Size = New Size(19, 21)
        LblAoNum3.TabIndex = 5
        LblAoNum3.Text = "3"
        ' 
        ' BtnAoFlagReset
        ' 
        BtnAoFlagReset.Location = New Point(15, 345)
        BtnAoFlagReset.Name = "BtnAoFlagReset"
        BtnAoFlagReset.Size = New Size(93, 25)
        BtnAoFlagReset.TabIndex = 2
        BtnAoFlagReset.Text = "Reset Flag"
        ' 
        ' PanelAoFlag5
        ' 
        PanelAoFlag5.Controls.Add(LblAoFlag5)
        PanelAoFlag5.Controls.Add(LblAoNum5)
        PanelAoFlag5.Location = New Point(15, 80)
        PanelAoFlag5.Name = "PanelAoFlag5"
        PanelAoFlag5.Size = New Size(93, 34)
        PanelAoFlag5.TabIndex = 18
        ' 
        ' LblAoFlag5
        ' 
        LblAoFlag5.AutoSize = True
        LblAoFlag5.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag5.Location = New Point(10, 7)
        LblAoFlag5.Name = "LblAoFlag5"
        LblAoFlag5.Size = New Size(32, 21)
        LblAoFlag5.TabIndex = 6
        LblAoFlag5.Text = "🚩"
        ' 
        ' LblAoNum5
        ' 
        LblAoNum5.AutoSize = True
        LblAoNum5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum5.Location = New Point(60, 7)
        LblAoNum5.Name = "LblAoNum5"
        LblAoNum5.Size = New Size(19, 21)
        LblAoNum5.TabIndex = 5
        LblAoNum5.Text = "5"
        ' 
        ' PanelAoFlag2
        ' 
        PanelAoFlag2.Controls.Add(LblAoFlag2)
        PanelAoFlag2.Controls.Add(LblAoNum2)
        PanelAoFlag2.Location = New Point(15, 185)
        PanelAoFlag2.Name = "PanelAoFlag2"
        PanelAoFlag2.Size = New Size(93, 34)
        PanelAoFlag2.TabIndex = 20
        ' 
        ' LblAoFlag2
        ' 
        LblAoFlag2.AutoSize = True
        LblAoFlag2.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag2.Location = New Point(10, 7)
        LblAoFlag2.Name = "LblAoFlag2"
        LblAoFlag2.Size = New Size(32, 21)
        LblAoFlag2.TabIndex = 6
        LblAoFlag2.Text = "🚩"
        ' 
        ' LblAoNum2
        ' 
        LblAoNum2.AutoSize = True
        LblAoNum2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum2.Location = New Point(60, 7)
        LblAoNum2.Name = "LblAoNum2"
        LblAoNum2.Size = New Size(19, 21)
        LblAoNum2.TabIndex = 5
        LblAoNum2.Text = "2"
        ' 
        ' PanelAoFlag1
        ' 
        PanelAoFlag1.Controls.Add(LblAoFlag1)
        PanelAoFlag1.Controls.Add(LblAoNum1)
        PanelAoFlag1.Location = New Point(15, 220)
        PanelAoFlag1.Name = "PanelAoFlag1"
        PanelAoFlag1.Size = New Size(93, 34)
        PanelAoFlag1.TabIndex = 19
        ' 
        ' LblAoFlag1
        ' 
        LblAoFlag1.AutoSize = True
        LblAoFlag1.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag1.Location = New Point(10, 7)
        LblAoFlag1.Name = "LblAoFlag1"
        LblAoFlag1.Size = New Size(32, 21)
        LblAoFlag1.TabIndex = 6
        LblAoFlag1.Text = "🚩"
        ' 
        ' LblAoNum1
        ' 
        LblAoNum1.AutoSize = True
        LblAoNum1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum1.Location = New Point(60, 7)
        LblAoNum1.Name = "LblAoNum1"
        LblAoNum1.Size = New Size(19, 21)
        LblAoNum1.TabIndex = 5
        LblAoNum1.Text = "1"
        ' 
        ' PanelAoFlag6
        ' 
        PanelAoFlag6.Controls.Add(LblAoFlag6)
        PanelAoFlag6.Controls.Add(LblAoNum6)
        PanelAoFlag6.Location = New Point(15, 44)
        PanelAoFlag6.Name = "PanelAoFlag6"
        PanelAoFlag6.Size = New Size(93, 34)
        PanelAoFlag6.TabIndex = 23
        PanelAoFlag6.Visible = False
        ' 
        ' LblAoFlag6
        ' 
        LblAoFlag6.AutoSize = True
        LblAoFlag6.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag6.Location = New Point(10, 7)
        LblAoFlag6.Name = "LblAoFlag6"
        LblAoFlag6.Size = New Size(32, 21)
        LblAoFlag6.TabIndex = 6
        LblAoFlag6.Text = "🚩"
        ' 
        ' LblAoNum6
        ' 
        LblAoNum6.AutoSize = True
        LblAoNum6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum6.Location = New Point(60, 7)
        LblAoNum6.Name = "LblAoNum6"
        LblAoNum6.Size = New Size(19, 21)
        LblAoNum6.TabIndex = 5
        LblAoNum6.Text = "6"
        ' 
        ' PanelAoFlag7
        ' 
        PanelAoFlag7.Controls.Add(LblAoFlag7)
        PanelAoFlag7.Controls.Add(LblAoNum7)
        PanelAoFlag7.Location = New Point(15, 9)
        PanelAoFlag7.Name = "PanelAoFlag7"
        PanelAoFlag7.Size = New Size(93, 34)
        PanelAoFlag7.TabIndex = 24
        PanelAoFlag7.Visible = False
        ' 
        ' LblAoFlag7
        ' 
        LblAoFlag7.AutoSize = True
        LblAoFlag7.Font = New Font("Segoe UI", 12.0F)
        LblAoFlag7.Location = New Point(10, 7)
        LblAoFlag7.Name = "LblAoFlag7"
        LblAoFlag7.Size = New Size(32, 21)
        LblAoFlag7.TabIndex = 6
        LblAoFlag7.Text = "🚩"
        ' 
        ' LblAoNum7
        ' 
        LblAoNum7.AutoSize = True
        LblAoNum7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblAoNum7.Location = New Point(60, 7)
        LblAoNum7.Name = "LblAoNum7"
        LblAoNum7.Size = New Size(19, 21)
        LblAoNum7.TabIndex = 5
        LblAoNum7.Text = "7"
        ' 
        ' Kata
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 721)
        Controls.Add(PanelMainCenter)
        Controls.Add(PanelRightSidebar)
        Controls.Add(PanelLeftSidebar)
        Controls.Add(PanelFooter)
        Controls.Add(PanelHeader)
        Name = "Kata"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KATA Main Control"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelAKA.ResumeLayout(False)
        PanelAKA.PerformLayout()
        CType(PicAkaSquarePlaceholder, ComponentModel.ISupportInitialize).EndInit()
        PanelFooter.ResumeLayout(False)
        PanelFooter.PerformLayout()
        CType(NumApiTimer, ComponentModel.ISupportInitialize).EndInit()
        PanelLeftSidebar.ResumeLayout(False)
        PnlJ1.ResumeLayout(False)
        PnlJ2.ResumeLayout(False)
        PnlJ3.ResumeLayout(False)
        PnlJ4.ResumeLayout(False)
        PnlJ5.ResumeLayout(False)
        PnlJ6.ResumeLayout(False)
        PnlJ7.ResumeLayout(False)
        PanelRightSidebar.ResumeLayout(False)
        PanelRightSidebar.PerformLayout()
        TabRightSettings.ResumeLayout(False)
        PageMatchDetailRight.ResumeLayout(False)
        PageMatchDetailRight.PerformLayout()
        PageMatchLogoRight.ResumeLayout(False)
        CType(PicMatchLogoRight, ComponentModel.ISupportInitialize).EndInit()
        CType(NumTatamiRight, ComponentModel.ISupportInitialize).EndInit()
        PnlSelectPlayer.ResumeLayout(False)
        PnlSelectPlayer.PerformLayout()
        CType(NumWaitMinRight, ComponentModel.ISupportInitialize).EndInit()
        CType(NumWaitSecRight, ComponentModel.ISupportInitialize).EndInit()
        CType(NumPerfMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NumPerfSec, ComponentModel.ISupportInitialize).EndInit()
        PanelMainCenter.ResumeLayout(False)
        PanelAO.ResumeLayout(False)
        PanelAO.PerformLayout()
        CType(PicAoSquarePlaceholder, ComponentModel.ISupportInitialize).EndInit()
        PanelJudgeScore.ResumeLayout(False)
        PanelAkaScore.ResumeLayout(False)
        PanelAkaScore.PerformLayout()
        CType(NumAkaJ7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAkaTotalScore, ComponentModel.ISupportInitialize).EndInit()
        PanelAoScore.ResumeLayout(False)
        PanelAoScore.PerformLayout()
        CType(NumAoJ7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoJ5, ComponentModel.ISupportInitialize).EndInit()
        CType(NumAoTotalScore, ComponentModel.ISupportInitialize).EndInit()
        PanelFlagSystem.ResumeLayout(False)
        PanelAkaFlags.ResumeLayout(False)
        PanelAkaFlag4.ResumeLayout(False)
        PanelAkaFlag4.PerformLayout()
        PanelAkaFlag3.ResumeLayout(False)
        PanelAkaFlag3.PerformLayout()
        PanelAkaFlag2.ResumeLayout(False)
        PanelAkaFlag2.PerformLayout()
        PanelAkaFlag1.ResumeLayout(False)
        PanelAkaFlag1.PerformLayout()
        PanelAkaFlag5.ResumeLayout(False)
        PanelAkaFlag5.PerformLayout()
        PanelAkaFlag6.ResumeLayout(False)
        PanelAkaFlag6.PerformLayout()
        PanelAkaFlag7.ResumeLayout(False)
        PanelAkaFlag7.PerformLayout()
        PanelAoFlags.ResumeLayout(False)
        PanelAoFlag4.ResumeLayout(False)
        PanelAoFlag4.PerformLayout()
        PanelAoFlag3.ResumeLayout(False)
        PanelAoFlag3.PerformLayout()
        PanelAoFlag5.ResumeLayout(False)
        PanelAoFlag5.PerformLayout()
        PanelAoFlag2.ResumeLayout(False)
        PanelAoFlag2.PerformLayout()
        PanelAoFlag1.ResumeLayout(False)
        PanelAoFlag1.PerformLayout()
        PanelAoFlag6.ResumeLayout(False)
        PanelAoFlag6.PerformLayout()
        PanelAoFlag7.ResumeLayout(False)
        PanelAoFlag7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents APIInfo As Button
    Friend WithEvents PanelAkaFlag5 As Panel
    Friend WithEvents PanelAkaFlag1 As Panel
    Friend WithEvents LblAkaFlag1 As Label
    Friend WithEvents LblAkaNum1 As Label
    Friend WithEvents LblAkaFlag5 As Label
    Friend WithEvents LblAkaNum5 As Label
    Friend WithEvents PanelAkaFlag2 As Panel
    Friend WithEvents LblAkaFlag2 As Label
    Friend WithEvents LblAkaNum2 As Label
    Friend WithEvents PanelAoFlag4 As Panel
    Friend WithEvents LblAoFlag4 As Label
    Friend WithEvents LblAoNum4 As Label
    Friend WithEvents PanelAoFlag3 As Panel
    Friend WithEvents LblAoFlag3 As Label
    Friend WithEvents LblAoNum3 As Label
    Friend WithEvents PanelAkaFlag4 As Panel
    Friend WithEvents LblAkaFlag4 As Label
    Friend WithEvents LblAkaNum4 As Label
    Friend WithEvents PanelAkaFlag3 As Panel
    Friend WithEvents LblAkaFlag3 As Label
    Friend WithEvents LblAkaNum3 As Label
    Friend WithEvents PanelAoFlag2 As Panel
    Friend WithEvents LblAoFlag2 As Label
    Friend WithEvents LblAoNum2 As Label
    Friend WithEvents PanelAoFlag1 As Panel
    Friend WithEvents LblAoFlag1 As Label
    Friend WithEvents LblAoNum1 As Label
    Friend WithEvents PanelAoFlag5 As Panel
    Friend WithEvents LblAoFlag5 As Label
    Friend WithEvents LblAoNum5 As Label
    Friend WithEvents LblAkaJ7 As Label
    Friend WithEvents NumAkaJ7 As NumericUpDown
    Friend WithEvents LblAkaJ6 As Label
    Friend WithEvents NumAkaJ6 As NumericUpDown
    Friend WithEvents LblAoJ7 As Label
    Friend WithEvents NumAoJ7 As NumericUpDown
    Friend WithEvents LblAoJ6 As Label
    Friend WithEvents NumAoJ6 As NumericUpDown
End Class
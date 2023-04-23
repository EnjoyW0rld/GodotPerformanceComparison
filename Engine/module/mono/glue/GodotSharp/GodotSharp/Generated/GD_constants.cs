
#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
namespace Godot
{
    public static partial class GD
    {
        /// <summary>
        /// <para>Scancodes with this bit applied are non-printable.</para>
        /// </summary>
        public const int Spkey = 16777216;
    }

    public enum Margin
    {
        /// <summary>
        /// <para>Left margin, usually used for <see cref="Godot.Control"/> or <see cref="Godot.StyleBox"/>-derived classes.</para>
        /// </summary>
        Left = 0,
        /// <summary>
        /// <para>Top margin, usually used for <see cref="Godot.Control"/> or <see cref="Godot.StyleBox"/>-derived classes.</para>
        /// </summary>
        Top = 1,
        /// <summary>
        /// <para>Right margin, usually used for <see cref="Godot.Control"/> or <see cref="Godot.StyleBox"/>-derived classes.</para>
        /// </summary>
        Right = 2,
        /// <summary>
        /// <para>Bottom margin, usually used for <see cref="Godot.Control"/> or <see cref="Godot.StyleBox"/>-derived classes.</para>
        /// </summary>
        Bottom = 3
    }

    public enum Corner
    {
        /// <summary>
        /// <para>Top-left corner.</para>
        /// </summary>
        TopLeft = 0,
        /// <summary>
        /// <para>Top-right corner.</para>
        /// </summary>
        TopRight = 1,
        /// <summary>
        /// <para>Bottom-right corner.</para>
        /// </summary>
        BottomRight = 2,
        /// <summary>
        /// <para>Bottom-left corner.</para>
        /// </summary>
        BottomLeft = 3
    }

    public enum Orientation
    {
        /// <summary>
        /// <para>General vertical alignment, usually used for <see cref="Godot.Separator"/>, <see cref="Godot.ScrollBar"/>, <see cref="Godot.Slider"/>, etc.</para>
        /// </summary>
        Vertical = 1,
        /// <summary>
        /// <para>General horizontal alignment, usually used for <see cref="Godot.Separator"/>, <see cref="Godot.ScrollBar"/>, <see cref="Godot.Slider"/>, etc.</para>
        /// </summary>
        Horizontal = 0
    }

    public enum HAlign
    {
        /// <summary>
        /// <para>Horizontal left alignment, usually for text-derived classes.</para>
        /// </summary>
        Left = 0,
        /// <summary>
        /// <para>Horizontal center alignment, usually for text-derived classes.</para>
        /// </summary>
        Center = 1,
        /// <summary>
        /// <para>Horizontal right alignment, usually for text-derived classes.</para>
        /// </summary>
        Right = 2
    }

    public enum VAlign
    {
        /// <summary>
        /// <para>Vertical top alignment, usually for text-derived classes.</para>
        /// </summary>
        Top = 0,
        /// <summary>
        /// <para>Vertical center alignment, usually for text-derived classes.</para>
        /// </summary>
        Center = 1,
        /// <summary>
        /// <para>Vertical bottom alignment, usually for text-derived classes.</para>
        /// </summary>
        Bottom = 2
    }

    public enum KeyList
    {
        /// <summary>
        /// <para>Escape key.</para>
        /// </summary>
        Escape = 16777217,
        /// <summary>
        /// <para>Tab key.</para>
        /// </summary>
        Tab = 16777218,
        /// <summary>
        /// <para>Shift+Tab key.</para>
        /// </summary>
        Backtab = 16777219,
        /// <summary>
        /// <para>Backspace key.</para>
        /// </summary>
        Backspace = 16777220,
        /// <summary>
        /// <para>Return key (on the main keyboard).</para>
        /// </summary>
        Enter = 16777221,
        /// <summary>
        /// <para>Enter key on the numeric keypad.</para>
        /// </summary>
        KpEnter = 16777222,
        /// <summary>
        /// <para>Insert key.</para>
        /// </summary>
        Insert = 16777223,
        /// <summary>
        /// <para>Delete key.</para>
        /// </summary>
        Delete = 16777224,
        /// <summary>
        /// <para>Pause key.</para>
        /// </summary>
        Pause = 16777225,
        /// <summary>
        /// <para>Print Screen key.</para>
        /// </summary>
        Print = 16777226,
        /// <summary>
        /// <para>System Request key.</para>
        /// </summary>
        Sysreq = 16777227,
        /// <summary>
        /// <para>Clear key.</para>
        /// </summary>
        Clear = 16777228,
        /// <summary>
        /// <para>Home key.</para>
        /// </summary>
        Home = 16777229,
        /// <summary>
        /// <para>End key.</para>
        /// </summary>
        End = 16777230,
        /// <summary>
        /// <para>Left arrow key.</para>
        /// </summary>
        Left = 16777231,
        /// <summary>
        /// <para>Up arrow key.</para>
        /// </summary>
        Up = 16777232,
        /// <summary>
        /// <para>Right arrow key.</para>
        /// </summary>
        Right = 16777233,
        /// <summary>
        /// <para>Down arrow key.</para>
        /// </summary>
        Down = 16777234,
        /// <summary>
        /// <para>Page Up key.</para>
        /// </summary>
        Pageup = 16777235,
        /// <summary>
        /// <para>Page Down key.</para>
        /// </summary>
        Pagedown = 16777236,
        /// <summary>
        /// <para>Shift key.</para>
        /// </summary>
        Shift = 16777237,
        /// <summary>
        /// <para>Control key.</para>
        /// </summary>
        Control = 16777238,
        /// <summary>
        /// <para>Meta key.</para>
        /// </summary>
        Meta = 16777239,
        /// <summary>
        /// <para>Alt key.</para>
        /// </summary>
        Alt = 16777240,
        /// <summary>
        /// <para>Caps Lock key.</para>
        /// </summary>
        Capslock = 16777241,
        /// <summary>
        /// <para>Num Lock key.</para>
        /// </summary>
        Numlock = 16777242,
        /// <summary>
        /// <para>Scroll Lock key.</para>
        /// </summary>
        Scrolllock = 16777243,
        /// <summary>
        /// <para>F1 key.</para>
        /// </summary>
        F1 = 16777244,
        /// <summary>
        /// <para>F2 key.</para>
        /// </summary>
        F2 = 16777245,
        /// <summary>
        /// <para>F3 key.</para>
        /// </summary>
        F3 = 16777246,
        /// <summary>
        /// <para>F4 key.</para>
        /// </summary>
        F4 = 16777247,
        /// <summary>
        /// <para>F5 key.</para>
        /// </summary>
        F5 = 16777248,
        /// <summary>
        /// <para>F6 key.</para>
        /// </summary>
        F6 = 16777249,
        /// <summary>
        /// <para>F7 key.</para>
        /// </summary>
        F7 = 16777250,
        /// <summary>
        /// <para>F8 key.</para>
        /// </summary>
        F8 = 16777251,
        /// <summary>
        /// <para>F9 key.</para>
        /// </summary>
        F9 = 16777252,
        /// <summary>
        /// <para>F10 key.</para>
        /// </summary>
        F10 = 16777253,
        /// <summary>
        /// <para>F11 key.</para>
        /// </summary>
        F11 = 16777254,
        /// <summary>
        /// <para>F12 key.</para>
        /// </summary>
        F12 = 16777255,
        /// <summary>
        /// <para>F13 key.</para>
        /// </summary>
        F13 = 16777256,
        /// <summary>
        /// <para>F14 key.</para>
        /// </summary>
        F14 = 16777257,
        /// <summary>
        /// <para>F15 key.</para>
        /// </summary>
        F15 = 16777258,
        /// <summary>
        /// <para>F16 key.</para>
        /// </summary>
        F16 = 16777259,
        /// <summary>
        /// <para>Multiply (*) key on the numeric keypad.</para>
        /// </summary>
        KpMultiply = 16777345,
        /// <summary>
        /// <para>Divide (/) key on the numeric keypad.</para>
        /// </summary>
        KpDivide = 16777346,
        /// <summary>
        /// <para>Subtract (-) key on the numeric keypad.</para>
        /// </summary>
        KpSubtract = 16777347,
        /// <summary>
        /// <para>Period (.) key on the numeric keypad.</para>
        /// </summary>
        KpPeriod = 16777348,
        /// <summary>
        /// <para>Add (+) key on the numeric keypad.</para>
        /// </summary>
        KpAdd = 16777349,
        /// <summary>
        /// <para>Number 0 on the numeric keypad.</para>
        /// </summary>
        Kp0 = 16777350,
        /// <summary>
        /// <para>Number 1 on the numeric keypad.</para>
        /// </summary>
        Kp1 = 16777351,
        /// <summary>
        /// <para>Number 2 on the numeric keypad.</para>
        /// </summary>
        Kp2 = 16777352,
        /// <summary>
        /// <para>Number 3 on the numeric keypad.</para>
        /// </summary>
        Kp3 = 16777353,
        /// <summary>
        /// <para>Number 4 on the numeric keypad.</para>
        /// </summary>
        Kp4 = 16777354,
        /// <summary>
        /// <para>Number 5 on the numeric keypad.</para>
        /// </summary>
        Kp5 = 16777355,
        /// <summary>
        /// <para>Number 6 on the numeric keypad.</para>
        /// </summary>
        Kp6 = 16777356,
        /// <summary>
        /// <para>Number 7 on the numeric keypad.</para>
        /// </summary>
        Kp7 = 16777357,
        /// <summary>
        /// <para>Number 8 on the numeric keypad.</para>
        /// </summary>
        Kp8 = 16777358,
        /// <summary>
        /// <para>Number 9 on the numeric keypad.</para>
        /// </summary>
        Kp9 = 16777359,
        /// <summary>
        /// <para>Left Super key (Windows key).</para>
        /// </summary>
        SuperL = 16777260,
        /// <summary>
        /// <para>Right Super key (Windows key).</para>
        /// </summary>
        SuperR = 16777261,
        /// <summary>
        /// <para>Context menu key.</para>
        /// </summary>
        Menu = 16777262,
        /// <summary>
        /// <para>Left Hyper key.</para>
        /// </summary>
        HyperL = 16777263,
        /// <summary>
        /// <para>Right Hyper key.</para>
        /// </summary>
        HyperR = 16777264,
        /// <summary>
        /// <para>Help key.</para>
        /// </summary>
        Help = 16777265,
        /// <summary>
        /// <para>Left Direction key.</para>
        /// </summary>
        DirectionL = 16777266,
        /// <summary>
        /// <para>Right Direction key.</para>
        /// </summary>
        DirectionR = 16777267,
        /// <summary>
        /// <para>Media back key. Not to be confused with the Back button on an Android device.</para>
        /// </summary>
        Back = 16777280,
        /// <summary>
        /// <para>Media forward key.</para>
        /// </summary>
        Forward = 16777281,
        /// <summary>
        /// <para>Media stop key.</para>
        /// </summary>
        Stop = 16777282,
        /// <summary>
        /// <para>Media refresh key.</para>
        /// </summary>
        Refresh = 16777283,
        /// <summary>
        /// <para>Volume down key.</para>
        /// </summary>
        Volumedown = 16777284,
        /// <summary>
        /// <para>Mute volume key.</para>
        /// </summary>
        Volumemute = 16777285,
        /// <summary>
        /// <para>Volume up key.</para>
        /// </summary>
        Volumeup = 16777286,
        /// <summary>
        /// <para>Bass Boost key.</para>
        /// </summary>
        Bassboost = 16777287,
        /// <summary>
        /// <para>Bass up key.</para>
        /// </summary>
        Bassup = 16777288,
        /// <summary>
        /// <para>Bass down key.</para>
        /// </summary>
        Bassdown = 16777289,
        /// <summary>
        /// <para>Treble up key.</para>
        /// </summary>
        Trebleup = 16777290,
        /// <summary>
        /// <para>Treble down key.</para>
        /// </summary>
        Trebledown = 16777291,
        /// <summary>
        /// <para>Media play key.</para>
        /// </summary>
        Mediaplay = 16777292,
        /// <summary>
        /// <para>Media stop key.</para>
        /// </summary>
        Mediastop = 16777293,
        /// <summary>
        /// <para>Previous song key.</para>
        /// </summary>
        Mediaprevious = 16777294,
        /// <summary>
        /// <para>Next song key.</para>
        /// </summary>
        Medianext = 16777295,
        /// <summary>
        /// <para>Media record key.</para>
        /// </summary>
        Mediarecord = 16777296,
        /// <summary>
        /// <para>Home page key.</para>
        /// </summary>
        Homepage = 16777297,
        /// <summary>
        /// <para>Favorites key.</para>
        /// </summary>
        Favorites = 16777298,
        /// <summary>
        /// <para>Search key.</para>
        /// </summary>
        Search = 16777299,
        /// <summary>
        /// <para>Standby key.</para>
        /// </summary>
        Standby = 16777300,
        /// <summary>
        /// <para>Open URL / Launch Browser key.</para>
        /// </summary>
        Openurl = 16777301,
        /// <summary>
        /// <para>Launch Mail key.</para>
        /// </summary>
        Launchmail = 16777302,
        /// <summary>
        /// <para>Launch Media key.</para>
        /// </summary>
        Launchmedia = 16777303,
        /// <summary>
        /// <para>Launch Shortcut 0 key.</para>
        /// </summary>
        Launch0 = 16777304,
        /// <summary>
        /// <para>Launch Shortcut 1 key.</para>
        /// </summary>
        Launch1 = 16777305,
        /// <summary>
        /// <para>Launch Shortcut 2 key.</para>
        /// </summary>
        Launch2 = 16777306,
        /// <summary>
        /// <para>Launch Shortcut 3 key.</para>
        /// </summary>
        Launch3 = 16777307,
        /// <summary>
        /// <para>Launch Shortcut 4 key.</para>
        /// </summary>
        Launch4 = 16777308,
        /// <summary>
        /// <para>Launch Shortcut 5 key.</para>
        /// </summary>
        Launch5 = 16777309,
        /// <summary>
        /// <para>Launch Shortcut 6 key.</para>
        /// </summary>
        Launch6 = 16777310,
        /// <summary>
        /// <para>Launch Shortcut 7 key.</para>
        /// </summary>
        Launch7 = 16777311,
        /// <summary>
        /// <para>Launch Shortcut 8 key.</para>
        /// </summary>
        Launch8 = 16777312,
        /// <summary>
        /// <para>Launch Shortcut 9 key.</para>
        /// </summary>
        Launch9 = 16777313,
        /// <summary>
        /// <para>Launch Shortcut A key.</para>
        /// </summary>
        Launcha = 16777314,
        /// <summary>
        /// <para>Launch Shortcut B key.</para>
        /// </summary>
        Launchb = 16777315,
        /// <summary>
        /// <para>Launch Shortcut C key.</para>
        /// </summary>
        Launchc = 16777316,
        /// <summary>
        /// <para>Launch Shortcut D key.</para>
        /// </summary>
        Launchd = 16777317,
        /// <summary>
        /// <para>Launch Shortcut E key.</para>
        /// </summary>
        Launche = 16777318,
        /// <summary>
        /// <para>Launch Shortcut F key.</para>
        /// </summary>
        Launchf = 16777319,
        /// <summary>
        /// <para>Unknown key.</para>
        /// </summary>
        Unknown = 33554431,
        /// <summary>
        /// <para>Space key.</para>
        /// </summary>
        Space = 32,
        /// <summary>
        /// <para>! key.</para>
        /// </summary>
        Exclam = 33,
        /// <summary>
        /// <para>" key.</para>
        /// </summary>
        Quotedbl = 34,
        /// <summary>
        /// <para># key.</para>
        /// </summary>
        Numbersign = 35,
        /// <summary>
        /// <para>$ key.</para>
        /// </summary>
        Dollar = 36,
        /// <summary>
        /// <para>% key.</para>
        /// </summary>
        Percent = 37,
        /// <summary>
        /// <para>&amp; key.</para>
        /// </summary>
        Ampersand = 38,
        /// <summary>
        /// <para>' key.</para>
        /// </summary>
        Apostrophe = 39,
        /// <summary>
        /// <para>( key.</para>
        /// </summary>
        Parenleft = 40,
        /// <summary>
        /// <para>) key.</para>
        /// </summary>
        Parenright = 41,
        /// <summary>
        /// <para>* key.</para>
        /// </summary>
        Asterisk = 42,
        /// <summary>
        /// <para>+ key.</para>
        /// </summary>
        Plus = 43,
        /// <summary>
        /// <para>, key.</para>
        /// </summary>
        Comma = 44,
        /// <summary>
        /// <para>- key.</para>
        /// </summary>
        Minus = 45,
        /// <summary>
        /// <para>. key.</para>
        /// </summary>
        Period = 46,
        /// <summary>
        /// <para>/ key.</para>
        /// </summary>
        Slash = 47,
        /// <summary>
        /// <para>Number 0.</para>
        /// </summary>
        Key0 = 48,
        /// <summary>
        /// <para>Number 1.</para>
        /// </summary>
        Key1 = 49,
        /// <summary>
        /// <para>Number 2.</para>
        /// </summary>
        Key2 = 50,
        /// <summary>
        /// <para>Number 3.</para>
        /// </summary>
        Key3 = 51,
        /// <summary>
        /// <para>Number 4.</para>
        /// </summary>
        Key4 = 52,
        /// <summary>
        /// <para>Number 5.</para>
        /// </summary>
        Key5 = 53,
        /// <summary>
        /// <para>Number 6.</para>
        /// </summary>
        Key6 = 54,
        /// <summary>
        /// <para>Number 7.</para>
        /// </summary>
        Key7 = 55,
        /// <summary>
        /// <para>Number 8.</para>
        /// </summary>
        Key8 = 56,
        /// <summary>
        /// <para>Number 9.</para>
        /// </summary>
        Key9 = 57,
        /// <summary>
        /// <para>: key.</para>
        /// </summary>
        Colon = 58,
        /// <summary>
        /// <para>; key.</para>
        /// </summary>
        Semicolon = 59,
        /// <summary>
        /// <para>&lt; key.</para>
        /// </summary>
        Less = 60,
        /// <summary>
        /// <para>= key.</para>
        /// </summary>
        Equal = 61,
        /// <summary>
        /// <para>&gt; key.</para>
        /// </summary>
        Greater = 62,
        /// <summary>
        /// <para>? key.</para>
        /// </summary>
        Question = 63,
        /// <summary>
        /// <para>@ key.</para>
        /// </summary>
        At = 64,
        /// <summary>
        /// <para>A key.</para>
        /// </summary>
        A = 65,
        /// <summary>
        /// <para>B key.</para>
        /// </summary>
        B = 66,
        /// <summary>
        /// <para>C key.</para>
        /// </summary>
        C = 67,
        /// <summary>
        /// <para>D key.</para>
        /// </summary>
        D = 68,
        /// <summary>
        /// <para>E key.</para>
        /// </summary>
        E = 69,
        /// <summary>
        /// <para>F key.</para>
        /// </summary>
        F = 70,
        /// <summary>
        /// <para>G key.</para>
        /// </summary>
        G = 71,
        /// <summary>
        /// <para>H key.</para>
        /// </summary>
        H = 72,
        /// <summary>
        /// <para>I key.</para>
        /// </summary>
        I = 73,
        /// <summary>
        /// <para>J key.</para>
        /// </summary>
        J = 74,
        /// <summary>
        /// <para>K key.</para>
        /// </summary>
        K = 75,
        /// <summary>
        /// <para>L key.</para>
        /// </summary>
        L = 76,
        /// <summary>
        /// <para>M key.</para>
        /// </summary>
        M = 77,
        /// <summary>
        /// <para>N key.</para>
        /// </summary>
        N = 78,
        /// <summary>
        /// <para>O key.</para>
        /// </summary>
        O = 79,
        /// <summary>
        /// <para>P key.</para>
        /// </summary>
        P = 80,
        /// <summary>
        /// <para>Q key.</para>
        /// </summary>
        Q = 81,
        /// <summary>
        /// <para>R key.</para>
        /// </summary>
        R = 82,
        /// <summary>
        /// <para>S key.</para>
        /// </summary>
        S = 83,
        /// <summary>
        /// <para>T key.</para>
        /// </summary>
        T = 84,
        /// <summary>
        /// <para>U key.</para>
        /// </summary>
        U = 85,
        /// <summary>
        /// <para>V key.</para>
        /// </summary>
        V = 86,
        /// <summary>
        /// <para>W key.</para>
        /// </summary>
        W = 87,
        /// <summary>
        /// <para>X key.</para>
        /// </summary>
        X = 88,
        /// <summary>
        /// <para>Y key.</para>
        /// </summary>
        Y = 89,
        /// <summary>
        /// <para>Z key.</para>
        /// </summary>
        Z = 90,
        /// <summary>
        /// <para>[ key.</para>
        /// </summary>
        Bracketleft = 91,
        /// <summary>
        /// <para>\ key.</para>
        /// </summary>
        Backslash = 92,
        /// <summary>
        /// <para>] key.</para>
        /// </summary>
        Bracketright = 93,
        /// <summary>
        /// <para>^ key.</para>
        /// </summary>
        Asciicircum = 94,
        /// <summary>
        /// <para>_ key.</para>
        /// </summary>
        Underscore = 95,
        /// <summary>
        /// <para>` key.</para>
        /// </summary>
        Quoteleft = 96,
        /// <summary>
        /// <para>{ key.</para>
        /// </summary>
        Braceleft = 123,
        /// <summary>
        /// <para>| key.</para>
        /// </summary>
        Bar = 124,
        /// <summary>
        /// <para>} key.</para>
        /// </summary>
        Braceright = 125,
        /// <summary>
        /// <para>~ key.</para>
        /// </summary>
        Asciitilde = 126,
        /// <summary>
        /// <para>Non-breakable space key.</para>
        /// </summary>
        Nobreakspace = 160,
        /// <summary>
        /// <para>¡ key.</para>
        /// </summary>
        Exclamdown = 161,
        /// <summary>
        /// <para>¢ key.</para>
        /// </summary>
        Cent = 162,
        /// <summary>
        /// <para>£ key.</para>
        /// </summary>
        Sterling = 163,
        /// <summary>
        /// <para>¤ key.</para>
        /// </summary>
        Currency = 164,
        /// <summary>
        /// <para>¥ key.</para>
        /// </summary>
        Yen = 165,
        /// <summary>
        /// <para>¦ key.</para>
        /// </summary>
        Brokenbar = 166,
        /// <summary>
        /// <para>§ key.</para>
        /// </summary>
        Section = 167,
        /// <summary>
        /// <para>¨ key.</para>
        /// </summary>
        Diaeresis = 168,
        /// <summary>
        /// <para>© key.</para>
        /// </summary>
        Copyright = 169,
        /// <summary>
        /// <para>ª key.</para>
        /// </summary>
        Ordfeminine = 170,
        /// <summary>
        /// <para>« key.</para>
        /// </summary>
        Guillemotleft = 171,
        /// <summary>
        /// <para>¬ key.</para>
        /// </summary>
        Notsign = 172,
        /// <summary>
        /// <para>Soft hyphen key.</para>
        /// </summary>
        Hyphen = 173,
        /// <summary>
        /// <para>® key.</para>
        /// </summary>
        Registered = 174,
        /// <summary>
        /// <para>¯ key.</para>
        /// </summary>
        Macron = 175,
        /// <summary>
        /// <para>° key.</para>
        /// </summary>
        Degree = 176,
        /// <summary>
        /// <para>± key.</para>
        /// </summary>
        Plusminus = 177,
        /// <summary>
        /// <para>² key.</para>
        /// </summary>
        Twosuperior = 178,
        /// <summary>
        /// <para>³ key.</para>
        /// </summary>
        Threesuperior = 179,
        /// <summary>
        /// <para>´ key.</para>
        /// </summary>
        Acute = 180,
        /// <summary>
        /// <para>µ key.</para>
        /// </summary>
        Mu = 181,
        /// <summary>
        /// <para>¶ key.</para>
        /// </summary>
        Paragraph = 182,
        /// <summary>
        /// <para>· key.</para>
        /// </summary>
        Periodcentered = 183,
        /// <summary>
        /// <para>¸ key.</para>
        /// </summary>
        Cedilla = 184,
        /// <summary>
        /// <para>¹ key.</para>
        /// </summary>
        Onesuperior = 185,
        /// <summary>
        /// <para>º key.</para>
        /// </summary>
        Masculine = 186,
        /// <summary>
        /// <para>» key.</para>
        /// </summary>
        Guillemotright = 187,
        /// <summary>
        /// <para>¼ key.</para>
        /// </summary>
        Onequarter = 188,
        /// <summary>
        /// <para>½ key.</para>
        /// </summary>
        Onehalf = 189,
        /// <summary>
        /// <para>¾ key.</para>
        /// </summary>
        Threequarters = 190,
        /// <summary>
        /// <para>¿ key.</para>
        /// </summary>
        Questiondown = 191,
        /// <summary>
        /// <para>À key.</para>
        /// </summary>
        Agrave = 192,
        /// <summary>
        /// <para>Á key.</para>
        /// </summary>
        Aacute = 193,
        /// <summary>
        /// <para>Â key.</para>
        /// </summary>
        Acircumflex = 194,
        /// <summary>
        /// <para>Ã key.</para>
        /// </summary>
        Atilde = 195,
        /// <summary>
        /// <para>Ä key.</para>
        /// </summary>
        Adiaeresis = 196,
        /// <summary>
        /// <para>Å key.</para>
        /// </summary>
        Aring = 197,
        /// <summary>
        /// <para>Æ key.</para>
        /// </summary>
        Ae = 198,
        /// <summary>
        /// <para>Ç key.</para>
        /// </summary>
        Ccedilla = 199,
        /// <summary>
        /// <para>È key.</para>
        /// </summary>
        Egrave = 200,
        /// <summary>
        /// <para>É key.</para>
        /// </summary>
        Eacute = 201,
        /// <summary>
        /// <para>Ê key.</para>
        /// </summary>
        Ecircumflex = 202,
        /// <summary>
        /// <para>Ë key.</para>
        /// </summary>
        Ediaeresis = 203,
        /// <summary>
        /// <para>Ì key.</para>
        /// </summary>
        Igrave = 204,
        /// <summary>
        /// <para>Í key.</para>
        /// </summary>
        Iacute = 205,
        /// <summary>
        /// <para>Î key.</para>
        /// </summary>
        Icircumflex = 206,
        /// <summary>
        /// <para>Ï key.</para>
        /// </summary>
        Idiaeresis = 207,
        /// <summary>
        /// <para>Ð key.</para>
        /// </summary>
        Eth = 208,
        /// <summary>
        /// <para>Ñ key.</para>
        /// </summary>
        Ntilde = 209,
        /// <summary>
        /// <para>Ò key.</para>
        /// </summary>
        Ograve = 210,
        /// <summary>
        /// <para>Ó key.</para>
        /// </summary>
        Oacute = 211,
        /// <summary>
        /// <para>Ô key.</para>
        /// </summary>
        Ocircumflex = 212,
        /// <summary>
        /// <para>Õ key.</para>
        /// </summary>
        Otilde = 213,
        /// <summary>
        /// <para>Ö key.</para>
        /// </summary>
        Odiaeresis = 214,
        /// <summary>
        /// <para>× key.</para>
        /// </summary>
        Multiply = 215,
        /// <summary>
        /// <para>Ø key.</para>
        /// </summary>
        Ooblique = 216,
        /// <summary>
        /// <para>Ù key.</para>
        /// </summary>
        Ugrave = 217,
        /// <summary>
        /// <para>Ú key.</para>
        /// </summary>
        Uacute = 218,
        /// <summary>
        /// <para>Û key.</para>
        /// </summary>
        Ucircumflex = 219,
        /// <summary>
        /// <para>Ü key.</para>
        /// </summary>
        Udiaeresis = 220,
        /// <summary>
        /// <para>Ý key.</para>
        /// </summary>
        Yacute = 221,
        /// <summary>
        /// <para>Þ key.</para>
        /// </summary>
        Thorn = 222,
        /// <summary>
        /// <para>ß key.</para>
        /// </summary>
        Ssharp = 223,
        /// <summary>
        /// <para>÷ key.</para>
        /// </summary>
        Division = 247,
        /// <summary>
        /// <para>ÿ key.</para>
        /// </summary>
        Ydiaeresis = 255
    }

    public enum KeyModifierMask
    {
        /// <summary>
        /// <para>Key Code mask.</para>
        /// </summary>
        CodeMask = 33554431,
        /// <summary>
        /// <para>Modifier key mask.</para>
        /// </summary>
        ModifierMask = -16777216,
        /// <summary>
        /// <para>Shift key mask.</para>
        /// </summary>
        MaskShift = 33554432,
        /// <summary>
        /// <para>Alt key mask.</para>
        /// </summary>
        MaskAlt = 67108864,
        /// <summary>
        /// <para>Meta key mask.</para>
        /// </summary>
        MaskMeta = 134217728,
        /// <summary>
        /// <para>Ctrl key mask.</para>
        /// </summary>
        MaskCtrl = 268435456,
        /// <summary>
        /// <para>Command key mask. On macOS, this is equivalent to <c>KEY_MASK_META</c>. On other platforms, this is equivalent to <c>KEY_MASK_CTRL</c>. This mask should be preferred to <c>KEY_MASK_META</c> or <c>KEY_MASK_CTRL</c> for system shortcuts as it handles all platforms correctly.</para>
        /// </summary>
        MaskCmd = 268435456,
        /// <summary>
        /// <para>Keypad key mask.</para>
        /// </summary>
        MaskKpad = 536870912,
        /// <summary>
        /// <para>Group Switch key mask.</para>
        /// </summary>
        MaskGroupSwitch = 1073741824
    }

    public enum ButtonList
    {
        /// <summary>
        /// <para>Left mouse button.</para>
        /// </summary>
        Left = 1,
        /// <summary>
        /// <para>Right mouse button.</para>
        /// </summary>
        Right = 2,
        /// <summary>
        /// <para>Middle mouse button.</para>
        /// </summary>
        Middle = 3,
        /// <summary>
        /// <para>Extra mouse button 1 (only present on some mice).</para>
        /// </summary>
        Xbutton1 = 8,
        /// <summary>
        /// <para>Extra mouse button 2 (only present on some mice).</para>
        /// </summary>
        Xbutton2 = 9,
        /// <summary>
        /// <para>Mouse wheel up.</para>
        /// </summary>
        WheelUp = 4,
        /// <summary>
        /// <para>Mouse wheel down.</para>
        /// </summary>
        WheelDown = 5,
        /// <summary>
        /// <para>Mouse wheel left button (only present on some mice).</para>
        /// </summary>
        WheelLeft = 6,
        /// <summary>
        /// <para>Mouse wheel right button (only present on some mice).</para>
        /// </summary>
        WheelRight = 7,
        /// <summary>
        /// <para>Left mouse button mask.</para>
        /// </summary>
        MaskLeft = 1,
        /// <summary>
        /// <para>Right mouse button mask.</para>
        /// </summary>
        MaskRight = 2,
        /// <summary>
        /// <para>Middle mouse button mask.</para>
        /// </summary>
        MaskMiddle = 4,
        /// <summary>
        /// <para>Extra mouse button 1 mask.</para>
        /// </summary>
        MaskXbutton1 = 128,
        /// <summary>
        /// <para>Extra mouse button 2 mask.</para>
        /// </summary>
        MaskXbutton2 = 256
    }

    public enum JoystickList
    {
        /// <summary>
        /// <para>Invalid button or axis.</para>
        /// </summary>
        InvalidOption = -1,
        /// <summary>
        /// <para>Gamepad button 0.</para>
        /// </summary>
        Button0 = 0,
        /// <summary>
        /// <para>Gamepad button 1.</para>
        /// </summary>
        Button1 = 1,
        /// <summary>
        /// <para>Gamepad button 2.</para>
        /// </summary>
        Button2 = 2,
        /// <summary>
        /// <para>Gamepad button 3.</para>
        /// </summary>
        Button3 = 3,
        /// <summary>
        /// <para>Gamepad button 4.</para>
        /// </summary>
        Button4 = 4,
        /// <summary>
        /// <para>Gamepad button 5.</para>
        /// </summary>
        Button5 = 5,
        /// <summary>
        /// <para>Gamepad button 6.</para>
        /// </summary>
        Button6 = 6,
        /// <summary>
        /// <para>Gamepad button 7.</para>
        /// </summary>
        Button7 = 7,
        /// <summary>
        /// <para>Gamepad button 8.</para>
        /// </summary>
        Button8 = 8,
        /// <summary>
        /// <para>Gamepad button 9.</para>
        /// </summary>
        Button9 = 9,
        /// <summary>
        /// <para>Gamepad button 10.</para>
        /// </summary>
        Button10 = 10,
        /// <summary>
        /// <para>Gamepad button 11.</para>
        /// </summary>
        Button11 = 11,
        /// <summary>
        /// <para>Gamepad button 12.</para>
        /// </summary>
        Button12 = 12,
        /// <summary>
        /// <para>Gamepad button 13.</para>
        /// </summary>
        Button13 = 13,
        /// <summary>
        /// <para>Gamepad button 14.</para>
        /// </summary>
        Button14 = 14,
        /// <summary>
        /// <para>Gamepad button 15.</para>
        /// </summary>
        Button15 = 15,
        /// <summary>
        /// <para>Gamepad button 16.</para>
        /// </summary>
        Button16 = 16,
        /// <summary>
        /// <para>Gamepad button 17.</para>
        /// </summary>
        Button17 = 17,
        /// <summary>
        /// <para>Gamepad button 18.</para>
        /// </summary>
        Button18 = 18,
        /// <summary>
        /// <para>Gamepad button 19.</para>
        /// </summary>
        Button19 = 19,
        /// <summary>
        /// <para>Gamepad button 20.</para>
        /// </summary>
        Button20 = 20,
        /// <summary>
        /// <para>Gamepad button 21.</para>
        /// </summary>
        Button21 = 21,
        /// <summary>
        /// <para>Gamepad button 22.</para>
        /// </summary>
        Button22 = 22,
        /// <summary>
        /// <para>The maximum number of game controller buttons supported by the engine. The actual limit may be lower on specific platforms:</para>
        /// <para>- Android: Up to 36 buttons.</para>
        /// <para>- Linux: Up to 80 buttons.</para>
        /// <para>- Windows and macOS: Up to 128 buttons.</para>
        /// </summary>
        ButtonMax = 128,
        /// <summary>
        /// <para>DualShock circle button.</para>
        /// </summary>
        SonyCircle = 1,
        /// <summary>
        /// <para>DualShock X button.</para>
        /// </summary>
        SonyX = 0,
        /// <summary>
        /// <para>DualShock square button.</para>
        /// </summary>
        SonySquare = 2,
        /// <summary>
        /// <para>DualShock triangle button.</para>
        /// </summary>
        SonyTriangle = 3,
        /// <summary>
        /// <para>Xbox controller B button.</para>
        /// </summary>
        XboxB = 1,
        /// <summary>
        /// <para>Xbox controller A button.</para>
        /// </summary>
        XboxA = 0,
        /// <summary>
        /// <para>Xbox controller X button.</para>
        /// </summary>
        XboxX = 2,
        /// <summary>
        /// <para>Xbox controller Y button.</para>
        /// </summary>
        XboxY = 3,
        /// <summary>
        /// <para>Nintendo controller A button.</para>
        /// </summary>
        DsA = 1,
        /// <summary>
        /// <para>Nintendo controller B button.</para>
        /// </summary>
        DsB = 0,
        /// <summary>
        /// <para>Nintendo controller X button.</para>
        /// </summary>
        DsX = 3,
        /// <summary>
        /// <para>Nintendo controller Y button.</para>
        /// </summary>
        DsY = 2,
        /// <summary>
        /// <para>Grip (side) buttons on a VR controller.</para>
        /// </summary>
        VrGrip = 2,
        /// <summary>
        /// <para>Push down on the touchpad or main joystick on a VR controller.</para>
        /// </summary>
        VrPad = 14,
        /// <summary>
        /// <para>Trigger on a VR controller.</para>
        /// </summary>
        VrTrigger = 15,
        /// <summary>
        /// <para>A button on the right Oculus Touch controller, X button on the left controller (also when used in OpenVR).</para>
        /// </summary>
        OculusAx = 7,
        /// <summary>
        /// <para>B button on the right Oculus Touch controller, Y button on the left controller (also when used in OpenVR).</para>
        /// </summary>
        OculusBy = 1,
        /// <summary>
        /// <para>Menu button on either Oculus Touch controller.</para>
        /// </summary>
        OculusMenu = 3,
        /// <summary>
        /// <para>Menu button in OpenVR (Except when Oculus Touch controllers are used).</para>
        /// </summary>
        OpenvrMenu = 1,
        /// <summary>
        /// <para>Gamepad button Select.</para>
        /// </summary>
        Select = 10,
        /// <summary>
        /// <para>Gamepad button Start.</para>
        /// </summary>
        Start = 11,
        /// <summary>
        /// <para>Gamepad DPad up.</para>
        /// </summary>
        DpadUp = 12,
        /// <summary>
        /// <para>Gamepad DPad down.</para>
        /// </summary>
        DpadDown = 13,
        /// <summary>
        /// <para>Gamepad DPad left.</para>
        /// </summary>
        DpadLeft = 14,
        /// <summary>
        /// <para>Gamepad DPad right.</para>
        /// </summary>
        DpadRight = 15,
        /// <summary>
        /// <para>Gamepad SDL guide button.</para>
        /// </summary>
        Guide = 16,
        /// <summary>
        /// <para>Gamepad SDL miscellaneous button.</para>
        /// </summary>
        Misc1 = 17,
        /// <summary>
        /// <para>Gamepad SDL paddle 1 button.</para>
        /// </summary>
        Paddle1 = 18,
        /// <summary>
        /// <para>Gamepad SDL paddle 2 button.</para>
        /// </summary>
        Paddle2 = 19,
        /// <summary>
        /// <para>Gamepad SDL paddle 3 button.</para>
        /// </summary>
        Paddle3 = 20,
        /// <summary>
        /// <para>Gamepad SDL paddle 4 button.</para>
        /// </summary>
        Paddle4 = 21,
        /// <summary>
        /// <para>Gamepad SDL touchpad button.</para>
        /// </summary>
        Touchpad = 22,
        /// <summary>
        /// <para>Gamepad left Shoulder button.</para>
        /// </summary>
        L = 4,
        /// <summary>
        /// <para>Gamepad left trigger.</para>
        /// </summary>
        L2 = 6,
        /// <summary>
        /// <para>Gamepad left stick click.</para>
        /// </summary>
        L3 = 8,
        /// <summary>
        /// <para>Gamepad right Shoulder button.</para>
        /// </summary>
        R = 5,
        /// <summary>
        /// <para>Gamepad right trigger.</para>
        /// </summary>
        R2 = 7,
        /// <summary>
        /// <para>Gamepad right stick click.</para>
        /// </summary>
        R3 = 9,
        /// <summary>
        /// <para>Gamepad left stick horizontal axis.</para>
        /// </summary>
        Axis0 = 0,
        /// <summary>
        /// <para>Gamepad left stick vertical axis.</para>
        /// </summary>
        Axis1 = 1,
        /// <summary>
        /// <para>Gamepad right stick horizontal axis.</para>
        /// </summary>
        Axis2 = 2,
        /// <summary>
        /// <para>Gamepad right stick vertical axis.</para>
        /// </summary>
        Axis3 = 3,
        /// <summary>
        /// <para>Generic gamepad axis 4.</para>
        /// </summary>
        Axis4 = 4,
        /// <summary>
        /// <para>Generic gamepad axis 5.</para>
        /// </summary>
        Axis5 = 5,
        /// <summary>
        /// <para>Gamepad left trigger analog axis.</para>
        /// </summary>
        Axis6 = 6,
        /// <summary>
        /// <para>Gamepad right trigger analog axis.</para>
        /// </summary>
        Axis7 = 7,
        /// <summary>
        /// <para>Generic gamepad axis 8.</para>
        /// </summary>
        Axis8 = 8,
        /// <summary>
        /// <para>Generic gamepad axis 9.</para>
        /// </summary>
        Axis9 = 9,
        /// <summary>
        /// <para>Represents the maximum number of joystick axes supported.</para>
        /// </summary>
        AxisMax = 10,
        /// <summary>
        /// <para>Gamepad left stick horizontal axis.</para>
        /// </summary>
        AnalogLx = 0,
        /// <summary>
        /// <para>Gamepad left stick vertical axis.</para>
        /// </summary>
        AnalogLy = 1,
        /// <summary>
        /// <para>Gamepad right stick horizontal axis.</para>
        /// </summary>
        AnalogRx = 2,
        /// <summary>
        /// <para>Gamepad right stick vertical axis.</para>
        /// </summary>
        AnalogRy = 3,
        /// <summary>
        /// <para>Gamepad left analog trigger.</para>
        /// </summary>
        AnalogL2 = 6,
        /// <summary>
        /// <para>Gamepad right analog trigger.</para>
        /// </summary>
        AnalogR2 = 7,
        /// <summary>
        /// <para>VR Controller analog trigger.</para>
        /// </summary>
        VrAnalogTrigger = 2,
        /// <summary>
        /// <para>VR Controller analog grip (side buttons).</para>
        /// </summary>
        VrAnalogGrip = 4,
        /// <summary>
        /// <para>OpenVR touchpad X axis (Joystick axis on Oculus Touch and Windows MR controllers).</para>
        /// </summary>
        OpenvrTouchpadx = 0,
        /// <summary>
        /// <para>OpenVR touchpad Y axis (Joystick axis on Oculus Touch and Windows MR controllers).</para>
        /// </summary>
        OpenvrTouchpady = 1
    }

    public enum MidiMessageList
    {
        /// <summary>
        /// <para>MIDI note OFF message. See the documentation of <see cref="Godot.InputEventMIDI"/> for information of how to use MIDI inputs.</para>
        /// </summary>
        NoteOff = 8,
        /// <summary>
        /// <para>MIDI note ON message. See the documentation of <see cref="Godot.InputEventMIDI"/> for information of how to use MIDI inputs.</para>
        /// </summary>
        NoteOn = 9,
        /// <summary>
        /// <para>MIDI aftertouch message. This message is most often sent by pressing down on the key after it "bottoms out".</para>
        /// </summary>
        Aftertouch = 10,
        /// <summary>
        /// <para>MIDI control change message. This message is sent when a controller value changes. Controllers include devices such as pedals and levers.</para>
        /// </summary>
        ControlChange = 11,
        /// <summary>
        /// <para>MIDI program change message. This message sent when the program patch number changes.</para>
        /// </summary>
        ProgramChange = 12,
        /// <summary>
        /// <para>MIDI channel pressure message. This message is most often sent by pressing down on the key after it "bottoms out". This message is different from polyphonic after-touch as it indicates the highest pressure across all keys.</para>
        /// </summary>
        ChannelPressure = 13,
        /// <summary>
        /// <para>MIDI pitch bend message. This message is sent to indicate a change in the pitch bender (wheel or lever, typically).</para>
        /// </summary>
        PitchBend = 14,
        /// <summary>
        /// <para>MIDI system exclusive message. This has behavior exclusive to the device you're receiving input from. Getting this data is not implemented in Godot.</para>
        /// </summary>
        SystemExclusive = 240,
        /// <summary>
        /// <para>MIDI quarter frame message. Contains timing information that is used to synchronize MIDI devices. Getting this data is not implemented in Godot.</para>
        /// </summary>
        QuarterFrame = 241,
        /// <summary>
        /// <para>MIDI song position pointer message. Gives the number of 16th notes since the start of the song. Getting this data is not implemented in Godot.</para>
        /// </summary>
        SongPositionPointer = 242,
        /// <summary>
        /// <para>MIDI song select message. Specifies which sequence or song is to be played. Getting this data is not implemented in Godot.</para>
        /// </summary>
        SongSelect = 243,
        /// <summary>
        /// <para>MIDI tune request message. Upon receiving a tune request, all analog synthesizers should tune their oscillators.</para>
        /// </summary>
        TuneRequest = 246,
        /// <summary>
        /// <para>MIDI timing clock message. Sent 24 times per quarter note when synchronization is required.</para>
        /// </summary>
        TimingClock = 248,
        /// <summary>
        /// <para>MIDI start message. Start the current sequence playing. This message will be followed with Timing Clocks.</para>
        /// </summary>
        Start = 250,
        /// <summary>
        /// <para>MIDI continue message. Continue at the point the sequence was stopped.</para>
        /// </summary>
        Continue = 251,
        /// <summary>
        /// <para>MIDI stop message. Stop the current sequence.</para>
        /// </summary>
        Stop = 252,
        /// <summary>
        /// <para>MIDI active sensing message. This message is intended to be sent repeatedly to tell the receiver that a connection is alive.</para>
        /// </summary>
        ActiveSensing = 254,
        /// <summary>
        /// <para>MIDI system reset message. Reset all receivers in the system to power-up status. It should not be sent on power-up itself.</para>
        /// </summary>
        SystemReset = 255
    }

    public enum Error
    {
        /// <summary>
        /// <para>Methods that return <see cref="Godot.Error"/> return <c>OK</c> when no error occurred. Note that many functions don't return an error code but will print error messages to standard output.</para>
        /// <para>Since <c>OK</c> has value 0, and all other failure codes are positive integers, it can also be used in boolean checks, e.g.:</para>
        /// <para><code>
        /// var err = method_that_returns_error()
        /// if err != OK:
        ///     print("Failure!")
        /// # Or, equivalent:
        /// if err:
        ///     print("Still failing!")
        /// </code></para>
        /// </summary>
        Ok = 0,
        /// <summary>
        /// <para>Generic error.</para>
        /// </summary>
        Failed = 1,
        /// <summary>
        /// <para>Unavailable error.</para>
        /// </summary>
        Unavailable = 2,
        /// <summary>
        /// <para>Unconfigured error.</para>
        /// </summary>
        Unconfigured = 3,
        /// <summary>
        /// <para>Unauthorized error.</para>
        /// </summary>
        Unauthorized = 4,
        /// <summary>
        /// <para>Parameter range error.</para>
        /// </summary>
        ParameterRangeError = 5,
        /// <summary>
        /// <para>Out of memory (OOM) error.</para>
        /// </summary>
        OutOfMemory = 6,
        /// <summary>
        /// <para>File: Not found error.</para>
        /// </summary>
        FileNotFound = 7,
        /// <summary>
        /// <para>File: Bad drive error.</para>
        /// </summary>
        FileBadDrive = 8,
        /// <summary>
        /// <para>File: Bad path error.</para>
        /// </summary>
        FileBadPath = 9,
        /// <summary>
        /// <para>File: No permission error.</para>
        /// </summary>
        FileNoPermission = 10,
        /// <summary>
        /// <para>File: Already in use error.</para>
        /// </summary>
        FileAlreadyInUse = 11,
        /// <summary>
        /// <para>File: Can't open error.</para>
        /// </summary>
        FileCantOpen = 12,
        /// <summary>
        /// <para>File: Can't write error.</para>
        /// </summary>
        FileCantWrite = 13,
        /// <summary>
        /// <para>File: Can't read error.</para>
        /// </summary>
        FileCantRead = 14,
        /// <summary>
        /// <para>File: Unrecognized error.</para>
        /// </summary>
        FileUnrecognized = 15,
        /// <summary>
        /// <para>File: Corrupt error.</para>
        /// </summary>
        FileCorrupt = 16,
        /// <summary>
        /// <para>File: Missing dependencies error.</para>
        /// </summary>
        FileMissingDependencies = 17,
        /// <summary>
        /// <para>File: End of file (EOF) error.</para>
        /// </summary>
        FileEof = 18,
        /// <summary>
        /// <para>Can't open error.</para>
        /// </summary>
        CantOpen = 19,
        /// <summary>
        /// <para>Can't create error.</para>
        /// </summary>
        CantCreate = 20,
        /// <summary>
        /// <para>Query failed error.</para>
        /// </summary>
        QueryFailed = 21,
        /// <summary>
        /// <para>Already in use error.</para>
        /// </summary>
        AlreadyInUse = 22,
        /// <summary>
        /// <para>Locked error.</para>
        /// </summary>
        Locked = 23,
        /// <summary>
        /// <para>Timeout error.</para>
        /// </summary>
        Timeout = 24,
        /// <summary>
        /// <para>Can't connect error.</para>
        /// </summary>
        CantConnect = 25,
        /// <summary>
        /// <para>Can't resolve error.</para>
        /// </summary>
        CantResolve = 26,
        /// <summary>
        /// <para>Connection error.</para>
        /// </summary>
        ConnectionError = 27,
        /// <summary>
        /// <para>Can't acquire resource error.</para>
        /// </summary>
        CantAcquireResource = 28,
        /// <summary>
        /// <para>Can't fork process error.</para>
        /// </summary>
        CantFork = 29,
        /// <summary>
        /// <para>Invalid data error.</para>
        /// </summary>
        InvalidData = 30,
        /// <summary>
        /// <para>Invalid parameter error.</para>
        /// </summary>
        InvalidParameter = 31,
        /// <summary>
        /// <para>Already exists error.</para>
        /// </summary>
        AlreadyExists = 32,
        /// <summary>
        /// <para>Does not exist error.</para>
        /// </summary>
        DoesNotExist = 33,
        /// <summary>
        /// <para>Database: Read error.</para>
        /// </summary>
        DatabaseCantRead = 34,
        /// <summary>
        /// <para>Database: Write error.</para>
        /// </summary>
        DatabaseCantWrite = 35,
        /// <summary>
        /// <para>Compilation failed error.</para>
        /// </summary>
        CompilationFailed = 36,
        /// <summary>
        /// <para>Method not found error.</para>
        /// </summary>
        MethodNotFound = 37,
        /// <summary>
        /// <para>Linking failed error.</para>
        /// </summary>
        LinkFailed = 38,
        /// <summary>
        /// <para>Script failed error.</para>
        /// </summary>
        ScriptFailed = 39,
        /// <summary>
        /// <para>Cycling link (import cycle) error.</para>
        /// </summary>
        CyclicLink = 40,
        /// <summary>
        /// <para>Invalid declaration error.</para>
        /// </summary>
        InvalidDeclaration = 41,
        /// <summary>
        /// <para>Duplicate symbol error.</para>
        /// </summary>
        DuplicateSymbol = 42,
        /// <summary>
        /// <para>Parse error.</para>
        /// </summary>
        ParseError = 43,
        /// <summary>
        /// <para>Busy error.</para>
        /// </summary>
        Busy = 44,
        /// <summary>
        /// <para>Skip error.</para>
        /// </summary>
        Skip = 45,
        /// <summary>
        /// <para>Help error.</para>
        /// </summary>
        Help = 46,
        /// <summary>
        /// <para>Bug error.</para>
        /// </summary>
        Bug = 47,
        /// <summary>
        /// <para>Printer on fire error. (This is an easter egg, no engine methods return this error code.)</para>
        /// </summary>
        PrinterOnFire = 48
    }

    public enum PropertyHint
    {
        /// <summary>
        /// <para>No hint for the edited property.</para>
        /// </summary>
        None = 0,
        /// <summary>
        /// <para>Hints that an integer or float property should be within a range specified via the hint string <c>"min,max"</c> or <c>"min,max,step"</c>. The hint string can optionally include <c>"or_greater"</c> and/or <c>"or_lesser"</c> to allow manual input going respectively above the max or below the min values. Example: <c>"-360,360,1,or_greater,or_lesser"</c>.</para>
        /// </summary>
        Range = 1,
        /// <summary>
        /// <para>Hints that a float property should be within an exponential range specified via the hint string <c>"min,max"</c> or <c>"min,max,step"</c>. The hint string can optionally include <c>"or_greater"</c> and/or <c>"or_lesser"</c> to allow manual input going respectively above the max or below the min values. Example: <c>"0.01,100,0.01,or_greater"</c>.</para>
        /// </summary>
        ExpRange = 2,
        /// <summary>
        /// <para>Hints that an integer, float or string property is an enumerated value to pick in a list specified via a hint string.</para>
        /// <para>The hint string is a comma separated list of names such as <c>"Hello,Something,Else"</c>. For integer and float properties, the first name in the list has value 0, the next 1, and so on. Explicit values can also be specified by appending <c>:integer</c> to the name, e.g. <c>"Zero,One,Three:3,Four,Six:6"</c>.</para>
        /// </summary>
        Enum = 3,
        /// <summary>
        /// <para>Hints that a string property can be an enumerated value to pick in a list specified via a hint string such as <c>"Hello,Something,Else"</c>.</para>
        /// <para>Unlike <c>PROPERTY_HINT_ENUM</c> a property with this hint still accepts arbitrary values and can be empty. The list of values serves to suggest possible values.</para>
        /// </summary>
        EnumSuggestion = 39,
        /// <summary>
        /// <para>Hints that a float property should be edited via an exponential easing function. The hint string can include <c>"attenuation"</c> to flip the curve horizontally and/or <c>"inout"</c> to also include in/out easing.</para>
        /// </summary>
        ExpEasing = 4,
        /// <summary>
        /// <para>Deprecated hint, unused.</para>
        /// </summary>
        Length = 5,
        /// <summary>
        /// <para>Deprecated hint, unused.</para>
        /// </summary>
        KeyAccel = 7,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask with named bit flags. For example, to allow toggling bits 0, 1, 2 and 4, the hint could be something like <c>"Bit0,Bit1,Bit2,,Bit4"</c>.</para>
        /// </summary>
        Flags = 8,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 2D render layers.</para>
        /// </summary>
        Layers2dRender = 9,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 2D physics layers.</para>
        /// </summary>
        Layers2dPhysics = 10,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 2D navigation layers.</para>
        /// </summary>
        Layers2dNavigation = 11,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 3D render layers.</para>
        /// </summary>
        Layers3dRender = 12,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 3D physics layers.</para>
        /// </summary>
        Layers3dPhysics = 13,
        /// <summary>
        /// <para>Hints that an integer property is a bitmask using the optionally named 3D navigation layers.</para>
        /// </summary>
        Layers3dNavigation = 14,
        /// <summary>
        /// <para>Hints that a string property is a path to a file. Editing it will show a file dialog for picking the path. The hint string can be a set of filters with wildcards like <c>"*.png,*.jpg"</c>.</para>
        /// </summary>
        File = 15,
        /// <summary>
        /// <para>Hints that a string property is a path to a directory. Editing it will show a file dialog for picking the path.</para>
        /// </summary>
        Dir = 16,
        /// <summary>
        /// <para>Hints that a string property is an absolute path to a file outside the project folder. Editing it will show a file dialog for picking the path. The hint string can be a set of filters with wildcards like <c>"*.png,*.jpg"</c>.</para>
        /// </summary>
        GlobalFile = 17,
        /// <summary>
        /// <para>Hints that a string property is an absolute path to a directory outside the project folder. Editing it will show a file dialog for picking the path.</para>
        /// </summary>
        GlobalDir = 18,
        /// <summary>
        /// <para>Hints that a property is an instance of a <see cref="Godot.Resource"/>-derived type, optionally specified via the hint string (e.g. <c>"Texture"</c>). Editing it will show a popup menu of valid resource types to instantiate.</para>
        /// </summary>
        ResourceType = 19,
        /// <summary>
        /// <para>Hints that a string property is text with line breaks. Editing it will show a text input field where line breaks can be typed.</para>
        /// </summary>
        MultilineText = 20,
        /// <summary>
        /// <para>Hints that a string property should have a placeholder text visible on its input field, whenever the property is empty. The hint string is the placeholder text to use.</para>
        /// </summary>
        PlaceholderText = 21,
        /// <summary>
        /// <para>Hints that a color property should be edited without changing its alpha component, i.e. only R, G and B channels are edited.</para>
        /// </summary>
        ColorNoAlpha = 22,
        /// <summary>
        /// <para>Hints that an image is compressed using lossy compression.</para>
        /// </summary>
        ImageCompressLossy = 23,
        /// <summary>
        /// <para>Hints that an image is compressed using lossless compression.</para>
        /// </summary>
        ImageCompressLossless = 24,
        ObjectId = 25,
        /// <summary>
        /// <para>Hint that a property represents a particular type. If a property is <c>TYPE_STRING</c>, allows to set a type from the create dialog. If you need to create an <see cref="Godot.Collections.Array"/> to contain elements of a specific type, the <c>hint_string</c> must encode nested types using <c>":"</c> and <c>"/"</c> for specifying <see cref="Godot.Resource"/> types. For instance:</para>
        /// <para><code>
        /// hint_string = "%s:" % [TYPE_INT] # Array of inteters.
        /// hint_string = "%s:%s:" % [TYPE_ARRAY, TYPE_REAL] # Two-dimensional array of floats.
        /// hint_string = "%s/%s:Resource" % [TYPE_OBJECT, TYPE_OBJECT] # Array of resources.
        /// hint_string = "%s:%s/%s:Resource" % [TYPE_ARRAY, TYPE_OBJECT, TYPE_OBJECT] # Two-dimensional array of resources.
        /// </code></para>
        /// <para>Note: The final colon is required to specify for properly detecting built-in types.</para>
        /// </summary>
        TypeString = 26,
        NodePathToEditedNode = 27,
        MethodOfVariantType = 28,
        MethodOfBaseType = 29,
        MethodOfInstance = 30,
        MethodOfScript = 31,
        PropertyOfVariantType = 32,
        PropertyOfBaseType = 33,
        PropertyOfInstance = 34,
        PropertyOfScript = 35,
        ObjectTooBig = 36,
        NodePathValidTypes = 37,
        SaveFile = 38,
        Max = 40
    }

    public enum PropertyUsageFlags
    {
        /// <summary>
        /// <para>The property is serialized and saved in the scene file (default).</para>
        /// </summary>
        Storage = 1,
        /// <summary>
        /// <para>The property is shown in the editor inspector (default).</para>
        /// </summary>
        Editor = 2,
        /// <summary>
        /// <para>Deprecated usage flag, unused.</para>
        /// </summary>
        Network = 4,
        /// <summary>
        /// <para>Deprecated usage flag, unused.</para>
        /// </summary>
        EditorHelper = 8,
        /// <summary>
        /// <para>The property can be checked in the editor inspector.</para>
        /// </summary>
        Checkable = 16,
        /// <summary>
        /// <para>The property is checked in the editor inspector.</para>
        /// </summary>
        Checked = 32,
        /// <summary>
        /// <para>The property is a translatable string.</para>
        /// </summary>
        Internationalized = 64,
        /// <summary>
        /// <para>Used to group properties together in the editor. See <see cref="Godot.EditorInspector"/>.</para>
        /// </summary>
        Group = 128,
        /// <summary>
        /// <para>Used to categorize properties together in the editor.</para>
        /// </summary>
        Category = 256,
        /// <summary>
        /// <para>The property does not save its state in <see cref="Godot.PackedScene"/>.</para>
        /// </summary>
        NoInstanceState = 2048,
        /// <summary>
        /// <para>Editing the property prompts the user for restarting the editor.</para>
        /// </summary>
        RestartIfChanged = 4096,
        /// <summary>
        /// <para>The property is a script variable which should be serialized and saved in the scene file.</para>
        /// </summary>
        ScriptVariable = 8192,
        /// <summary>
        /// <para>Default usage (storage, editor and network).</para>
        /// </summary>
        Default = 7,
        /// <summary>
        /// <para>Default usage for translatable strings (storage, editor, network and internationalized).</para>
        /// </summary>
        DefaultIntl = 71,
        /// <summary>
        /// <para>Default usage but without showing the property in the editor (storage, network).</para>
        /// </summary>
        Noeditor = 5
    }

    public enum MethodFlags
    {
        /// <summary>
        /// <para>Flag for a normal method.</para>
        /// </summary>
        Normal = 1,
        /// <summary>
        /// <para>Flag for an editor method.</para>
        /// </summary>
        Editor = 2,
        /// <summary>
        /// <para>Deprecated method flag, unused.</para>
        /// </summary>
        Noscript = 4,
        /// <summary>
        /// <para>Flag for a constant method.</para>
        /// </summary>
        Const = 8,
        /// <summary>
        /// <para>Deprecated method flag, unused.</para>
        /// </summary>
        Reverse = 16,
        /// <summary>
        /// <para>Flag for a virtual method.</para>
        /// </summary>
        Virtual = 32,
        /// <summary>
        /// <para>Deprecated method flag, unused.</para>
        /// </summary>
        FromScript = 64,
        Vararg = 128,
        /// <summary>
        /// <para>Default method flags.</para>
        /// </summary>
        Default = 1
    }

    public static partial class Variant
    {

    public enum Type
    {
        /// <summary>
        /// <para>Variable is <c>null</c>.</para>
        /// </summary>
        Nil = 0,
        /// <summary>
        /// <para>Variable is of type <see cref="bool"/>.</para>
        /// </summary>
        Bool = 1,
        /// <summary>
        /// <para>Variable is of type <see cref="int"/>.</para>
        /// </summary>
        Int = 2,
        /// <summary>
        /// <para>Variable is of type <see cref="float"/> (real).</para>
        /// </summary>
        Real = 3,
        /// <summary>
        /// <para>Variable is of type <see cref="string"/>.</para>
        /// </summary>
        String = 4,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Vector2"/>.</para>
        /// </summary>
        Vector2 = 5,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Rect2"/>.</para>
        /// </summary>
        Rect2 = 6,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Vector3"/>.</para>
        /// </summary>
        Vector3 = 7,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Transform2D"/>.</para>
        /// </summary>
        Transform2d = 8,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Plane"/>.</para>
        /// </summary>
        Plane = 9,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Quat"/>.</para>
        /// </summary>
        Quat = 10,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.AABB"/>.</para>
        /// </summary>
        Aabb = 11,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Basis"/>.</para>
        /// </summary>
        Basis = 12,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Transform"/>.</para>
        /// </summary>
        Transform = 13,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Color"/>.</para>
        /// </summary>
        Color = 14,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.NodePath"/>.</para>
        /// </summary>
        NodePath = 15,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.RID"/>.</para>
        /// </summary>
        Rid = 16,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Object"/>.</para>
        /// </summary>
        Object = 17,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Collections.Dictionary"/>.</para>
        /// </summary>
        Dictionary = 18,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Collections.Array"/>.</para>
        /// </summary>
        Array = 19,
        /// <summary>
        /// <para>Variable is of type <see cref="byte"/>.</para>
        /// </summary>
        RawArray = 20,
        /// <summary>
        /// <para>Variable is of type <see cref="int"/>.</para>
        /// </summary>
        IntArray = 21,
        /// <summary>
        /// <para>Variable is of type <see cref="float"/>.</para>
        /// </summary>
        RealArray = 22,
        /// <summary>
        /// <para>Variable is of type <see cref="string"/>.</para>
        /// </summary>
        StringArray = 23,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Vector2"/>.</para>
        /// </summary>
        Vector2Array = 24,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Vector3"/>.</para>
        /// </summary>
        Vector3Array = 25,
        /// <summary>
        /// <para>Variable is of type <see cref="Godot.Color"/>.</para>
        /// </summary>
        ColorArray = 26,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.Variant.Type"/> enum.</para>
        /// </summary>
        Max = 27
    }
    }

    public static partial class Variant
    {

    public enum Operator
    {
        /// <summary>
        /// <para>Equality operator (<c>==</c>).</para>
        /// </summary>
        Equal = 0,
        /// <summary>
        /// <para>Inequality operator (<c>!=</c>).</para>
        /// </summary>
        NotEqual = 1,
        /// <summary>
        /// <para>Less than operator (<c>&lt;</c>).</para>
        /// </summary>
        Less = 2,
        /// <summary>
        /// <para>Less than or equal operator (<c>&lt;=</c>).</para>
        /// </summary>
        LessEqual = 3,
        /// <summary>
        /// <para>Greater than operator (<c>&gt;</c>).</para>
        /// </summary>
        Greater = 4,
        /// <summary>
        /// <para>Greater than or equal operator (<c>&gt;=</c>).</para>
        /// </summary>
        GreaterEqual = 5,
        /// <summary>
        /// <para>Addition operator (<c>+</c>).</para>
        /// </summary>
        Add = 6,
        /// <summary>
        /// <para>Subtraction operator (<c>-</c>).</para>
        /// </summary>
        Subtract = 7,
        /// <summary>
        /// <para>Multiplication operator (<c>*</c>).</para>
        /// </summary>
        Multiply = 8,
        /// <summary>
        /// <para>Division operator (<c>/</c>).</para>
        /// </summary>
        Divide = 9,
        /// <summary>
        /// <para>Unary negation operator (<c>-</c>).</para>
        /// </summary>
        Negate = 10,
        /// <summary>
        /// <para>Unary plus operator (<c>+</c>).</para>
        /// </summary>
        Positive = 11,
        /// <summary>
        /// <para>Remainder/modulo operator (<c>%</c>).</para>
        /// </summary>
        Module = 12,
        /// <summary>
        /// <para>String concatenation operator (<c>+</c>).</para>
        /// </summary>
        StringConcat = 13,
        /// <summary>
        /// <para>Left shift operator (<c>&lt;&lt;</c>).</para>
        /// </summary>
        ShiftLeft = 14,
        /// <summary>
        /// <para>Right shift operator (<c>&gt;&gt;</c>).</para>
        /// </summary>
        ShiftRight = 15,
        /// <summary>
        /// <para>Bitwise AND operator (<c>&amp;</c>).</para>
        /// </summary>
        BitAnd = 16,
        /// <summary>
        /// <para>Bitwise OR operator (<c>|</c>).</para>
        /// </summary>
        BitOr = 17,
        /// <summary>
        /// <para>Bitwise XOR operator (<c>^</c>).</para>
        /// </summary>
        BitXor = 18,
        /// <summary>
        /// <para>Bitwise NOT operator (<c>~</c>).</para>
        /// </summary>
        BitNegate = 19,
        /// <summary>
        /// <para>Logical AND operator (<c>and</c> or <c>&amp;&amp;</c>).</para>
        /// </summary>
        And = 20,
        /// <summary>
        /// <para>Logical OR operator (<c>or</c> or <c>||</c>).</para>
        /// </summary>
        Or = 21,
        /// <summary>
        /// <para>Logical XOR operator (not implemented in GDScript).</para>
        /// </summary>
        Xor = 22,
        /// <summary>
        /// <para>Logical NOT operator (<c>not</c> or <c>!</c>).</para>
        /// </summary>
        Not = 23,
        /// <summary>
        /// <para>Logical IN operator (<c>in</c>).</para>
        /// </summary>
        In = 24,
        /// <summary>
        /// <para>Represents the size of the <see cref="Godot.Variant.Operator"/> enum.</para>
        /// </summary>
        Max = 25
    }
    }
}

#pragma warning restore CS1591

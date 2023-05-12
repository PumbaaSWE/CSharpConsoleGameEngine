using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static ConsoleGameEngine.NativeMethods;


namespace ConsoleGameEngine
{

    public enum KeyCode
    {
        ABNT_C1	    = 0xC1,	//Abnt C1
        ABNT_C2	    = 0xC2,	//Abnt C2
        ADD	        = 0x6B,	//Numpad +
        ATTN	        = 0xF6,	//Attn
        BACK	        = 0x08,	//Backspace
        CANCEL	    = 0x03,	//Break
        CLEAR	    = 0x0C,	//Clear
        CRSEL	    = 0xF7,	//Cr Sel
        DECIMAL	    = 0x6E,	//Numpad .
        DIVIDE	    = 0x6F,	//Numpad /
        EREOF	    = 0xF9,	//Er Eof
        ESCAPE	    = 0x1B,	//Esc
        EXECUTE	    = 0x2B,	//Execute
        EXSEL	    = 0xF8,	//Ex Sel
        ICO_CLEAR    =0xE6, 	//IcoClr
        ICO_HELP	    = 0xE3, //	IcoHlp
        KEY_0	    = 0x30, // ('0')	0
        KEY_1	    = 0x31, // ('1')	1
        KEY_2	    = 0x32, // ('2')	2
        KEY_3	    = 0x33, // ('3')	3
        KEY_4	    = 0x34, // ('4')	4
        KEY_5	    = 0x35, // ('5')	5
        KEY_6	    = 0x36, // ('6')	6
        KEY_7	    = 0x37, // ('7')	7
        KEY_8	    = 0x38, // ('8')	8
        KEY_9	    = 0x39, // ('9')	9
        A	    = 0x41, // ('A')	A
        B	    = 0x42, // ('B')	B
        C	    = 0x43, // ('C')	C
        D	    = 0x44, // ('D')	D
        E	    = 0x45, // ('E')	E
        F	    = 0x46, // ('F')	F
        G	    = 0x47, // ('G')	G
        H	    = 0x48, // ('H')	H
        I	    = 0x49, // ('I')	I
        J	    = 0x4A, // ('J')	J
        K	    = 0x4B, // ('K')	K
        L	    = 0x4C, // ('L')	L
        M	    = 0x4D, // ('M')	M
        N	    = 0x4E, // ('N')	N
        O	    = 0x4F, // ('O')	O
        P	    = 0x50, // ('P')	P
        Q	    = 0x51, // ('Q')	Q
        R	    = 0x52, // ('R')	R
        S	    = 0x53, // ('S')	S
        T	    = 0x54, // ('T')	T
        U	    = 0x55, // ('U')	U
        V	    = 0x56, // ('V')	V
        W	    = 0x57, // ('W')	W
        X	    = 0x58, // ('X')	X
        Y	    = 0x59, // ('Y')	Y
        Z	    = 0x5A, // ('Z')	Z
        MULTIPLY	    = 0x6A, //	Numpad *
        NONAME	    = 0xFC, //	NoName
        NUMPAD0	    = 0x60, //	Numpad 0
        NUMPAD1	    = 0x61, //	Numpad 1
        NUMPAD2	    = 0x62, //	Numpad 2
        NUMPAD3	    = 0x63, //	Numpad 3
        NUMPAD4	    = 0x64, //	Numpad 4
        NUMPAD5	    = 0x65, //	Numpad 5
        NUMPAD6	    = 0x66, //	Numpad 6
        NUMPAD7	    = 0x67, //	Numpad 7
        NUMPAD8	    = 0x68, //	Numpad 8
        NUMPAD9	    = 0x69, //	Numpad 9
        OEM_1	    = 0xBA, //	OEM_1 (: ;)
        OEM_102	    = 0xE2, //	OEM_102 (> <)
        OEM_2	    = 0xBF, //	OEM_2 (? /)
        OEM_3	    = 0xC0, //	OEM_3 (~ `)
        OEM_4	    = 0xDB, //	OEM_4 ({ [)
        OEM_5	    = 0xDC, //	OEM_5(| \)
        OEM_6	    = 0xDD, //	OEM_6(} ])
        OEM_7	    = 0xDE,	//OEM_7(" ')
        OEM_8        = 0xDF,	//OEM_8 (§ !)
        OEM_ATTN	    = 0xF0,	//Oem Attn
        OEM_AUTO	    = 0xF3,	//Auto
        OEM_AX       = 0xE1,	//Ax
        OEM_BACKTAB  = 0xF5,	//Back Tab
        OEM_CLEAR	= 0xFE,	//OemClr
        OEM_COMMA    = 0xBC,	//OEM_COMMA(< ,)
        OEM_COPY	    = 0xF2,	//Copy
        OEM_CUSEL    = 0xEF,	//Cu Sel
        OEM_ENLW	    = 0xF4,	//Enlw
        OEM_FINISH   = 0xF1,	//Finish
        OEM_FJ_LOYA  = 0x95,	//Loya
        OEM_FJ_MASSHOU  = 0x93,	//Mashu
        OEM_FJ_ROYA     = 0x96,	//Roya
        OEM_FJ_TOUROKU  = 0x94,	//Touroku
        OEM_JUMP     = 0xEA,	//Jump
        OEM_MINUS    = 0xBD,	//OEM_MINUS(_ -)
        OEM_PA1	    = 0xEB,	//OemPa1
        OEM_PA2      = 0xEC,	//OemPa2
        OEM_PA3      = 0xED,	//OemPa3
        OEM_PERIOD   = 0xBE,	//OEM_PERIOD(> .)
        OEM_PLUS	    = 0xBB,	//OEM_PLUS(+ =)
        OEM_RESET	= 0xE9,	//Reset
        OEM_WSCTRL   = 0xEE,	//WsCtrl
        PA1          = 0xFD,	//Pa1
        PACKET       = 0xE7,	//Packet
        PLAY         = 0xFA,	//Play
        PROCESSKEY   = 0xE5,	//Process
        RETURN       = 0x0D,	//Enter
        SELECT       = 0x29,	//Select
        SEPARATOR    = 0x6C,	//Separator
        SPACE        = 0x20,	//Space
        SUBTRACT     = 0x6D,	//Num -
        TAB	        = 0x09,	//Tab
        ZOOM         = 0xFB,	//Zoom

        _none_	        = 0xFF,	//no VK mapping
        ACCEPT	        = 0x1E,	//Accept
        APPS	            = 0x5D,	//Context Menu
        BROWSER_BACK	    = 0xA6,	//Browser Back
        BROWSER_FAVORITES= 0xAB,	//Browser Favorites
        BROWSER_FORWARD	= 0xA7,	//Browser Forward
        BROWSER_HOME	    = 0xAC,	//Browser Home
        BROWSER_REFRESH	= 0xA8,	//Browser Refresh
        BROWSER_SEARCH	= 0xAA,	//Browser Search
        BROWSER_STOP	    = 0xA9,	//Browser Stop
        CAPITAL	        = 0x14,	//Caps Lock
        CONVERT	        = 0x1C,	//Convert
        DELETE	        = 0x2E,	//Delete
        DOWN	            = 0x28,	//Arrow Down
        END	            = 0x23,	//End
        F1	            = 0x70,	//F1
        F10	            = 0x79,	//F10
        F11	            = 0x7A,	//F11
        F12	            = 0x7B,	//F12
        F13	            = 0x7C,	//F13
        F14	            = 0x7D,	//F14
        F15	            = 0x7E,	//F15
        F16	            = 0x7F,	//F16
        F17	            = 0x80,	//F17
        F18	            = 0x81,	//F18
        F19	            = 0x82,	//F19
        F2	            = 0x71,	//F2
        F20	            = 0x83,	//F20
        F21	            = 0x84,	//F21
        F22	            = 0x85,	//F22
        F23	            = 0x86,	//F23
        F24	            = 0x87,	//F24
        F3	            = 0x72,	//F3
        F4	            = 0x73,	//F4
        F5	            = 0x74,	//F5
        F6	            = 0x75,	//F6
        F7	            = 0x76,	//F7
        F8	            = 0x77,	//F8
        F9	            = 0x78,	//F9
        FINAL	        = 0x18,	//Final
        HELP	            = 0x2F,	//Help
        HOME	            = 0x24,	//Home
        ICO_00	        = 0xE4,	//Ico00 *
        INSERT	        = 0x2D,	//Insert
        JUNJA	        = 0x17,	//Junja
        KANA	            = 0x15,	//Kana
        KANJI	        = 0x19,	//Kanji
        LAUNCH_APP1	    = 0xB6,	//App1
        LAUNCH_APP2	    = 0xB7,	//App2
        LAUNCH_MAIL	    = 0xB4,	//Mail
        LAUNCH_MEDIA_SELECT =0xB5,	//Media
        LBUTTON	        = 0x01,	//Left Button **
        LCONTROL	        = 0xA2,	//Left Ctrl
        LEFT	            = 0x25,	//Arrow Left
        LMENU	        = 0xA4,	//Left Alt
        LSHIFT	        = 0xA0,	//Left Shift
        LWIN	            = 0x5B,	//Left Win
        MBUTTON	        = 0x04,	//Middle Button **
        MEDIA_NEXT_TRACK	= 0xB0,	//Next Track
        MEDIA_PLAY_PAUSE	= 0xB3,	//Play / Pause
        MEDIA_PREV_TRACK	= 0xB1,	//Previous Track
        MEDIA_STOP	    = 0xB2,	//Stop
        MODECHANGE	    = 0x1F,	//Mode Change
        NEXT	            = 0x22,	//Page Down
        NONCONVERT	    = 0x1D,	//Non Convert
        NUMLOCK	        = 0x90,	//Num Lock
        OEM_FJ_JISHO	    = 0x92,	//Jisho
        PAUSE	        = 0x13,	//Pause
        PRINT	        = 0x2A,	//Print
        PRIOR	        = 0x21,	//Page Up
        RBUTTON	        = 0x02,	//Right Button **
        RCONTROL	        = 0xA3,	//Right Ctrl
        RIGHT	        = 0x27,	//Arrow Right
        RMENU	        = 0xA5,	//Right Alt
        RSHIFT	        = 0xA1,	//Right Shift
        RWIN	            = 0x5C,	//Right Win
        SCROLL	        = 0x91,	//Scrol Lock
        SLEEP	        = 0x5F,	//Sleep
        SNAPSHOT	        = 0x2C,	//Print Screen
        UP	            = 0x26,	//Arrow Up
        VOLUME_DOWN	    = 0xAE,	//Volume Down
        VOLUME_MUTE	    = 0xAD,	//Volume Mute
        VOLUME_UP	    = 0xAF,	//Volume Up
        XBUTTON1	        = 0x05,	//X Button 1 **
        XBUTTON2	        = 0x06,	//X Button 2 **
    }

    public enum Color
    {
        FG_BLACK = 0x0000,
        FG_DARK_BLUE = 0x0001,
        FG_DARK_GREEN = 0x0002,
        FG_DARK_CYAN = 0x0003,
        FG_DARK_RED = 0x0004,
        FG_DARK_MAGENTA = 0x0005,
        FG_DARK_YELLOW = 0x0006,
        FG_GREY = 0x0007,
        FG_DARK_GREY = 0x0008,
        FG_BLUE = 0x0009,
        FG_GREEN = 0x000A,
        FG_CYAN = 0x000B,
        FG_RED = 0x000C,
        FG_MAGENTA = 0x000D,
        FG_YELLOW = 0x000E,
        FG_WHITE = 0x000F,
        BG_BLACK = 0x0000,
        BG_DARK_BLUE = 0x0010,
        BG_DARK_GREEN = 0x0020,
        BG_DARK_CYAN = 0x0030,
        BG_DARK_RED = 0x0040,
        BG_DARK_MAGENTA = 0x0050,
        BG_DARK_YELLOW = 0x0060,
        BG_GREY = 0x0070,
        BG_DARK_GREY = 0x0080,
        BG_BLUE = 0x0090,
        BG_GREEN = 0x00A0,
        BG_CYAN = 0x00B0,
        BG_RED = 0x00C0,
        BG_MAGENTA = 0x00D0,
        BG_YELLOW = 0x00E0,
        BG_WHITE = 0x00F0,
    };

    public enum PixelType
    {
        Solid = 0x2588,
        ThreeQuarters = 0x2593,
        Half = 0x2592,
        Quarter = 0x2591,
    };

    public abstract class ConsoleGame
    {
        /// <summary>
        /// Foreground colors for the pixel
        /// </summary>
        public const short  FG_BLACK = 0x0000,
                            FG_DARK_BLUE = 0x0001,
                            FG_DARK_GREEN = 0x0002,
                            FG_DARK_CYAN = 0x0003,
                            FG_DARK_RED = 0x0004,
                            FG_DARK_MAGENTA = 0x0005,
                            FG_DARK_YELLOW = 0x0006,
                            FG_GREY = 0x0007,
                            FG_DARK_GREY = 0x0008,
                            FG_BLUE = 0x0009,
                            FG_GREEN = 0x000A,
                            FG_CYAN = 0x000B,
                            FG_RED = 0x000C,
                            FG_MAGENTA = 0x000D,
                            FG_YELLOW = 0x000E,
                            FG_WHITE = 0x000F;
        /// <summary>
        /// Background colors for the pixel
        /// </summary>
        public const short  BG_BLACK = 0x0000,
                            BG_DARK_BLUE = 0x0010,
                            BG_DARK_GREEN = 0x0020,
                            BG_DARK_CYAN = 0x0030,
                            BG_DARK_RED = 0x0040,
                            BG_DARK_MAGENTA = 0x0050,
                            BG_DARK_YELLOW = 0x0060,
                            BG_GREY = 0x0070,
                            BG_DARK_GREY = 0x0080,
                            BG_BLUE = 0x0090,
                            BG_GREEN = 0x00A0,
                            BG_CYAN = 0x00B0,
                            BG_RED = 0x00C0,
                            BG_MAGENTA = 0x00D0,
                            BG_YELLOW = 0x00E0,
                            BG_WHITE = 0x00F0;
        /// <summary>
        /// Pixel types to represent different alpha values
        /// </summary>
        public const ushort PixelSolid = 0x2588,
                            PixelThreeQuarters = 0x2593,
                            PixelHalf = 0x2592,
                            PixelQuarter = 0x2591;
        
        //Screen
        private CharInfo[] screenBuffer;
        private SmallRect screenArea;
        private SmallRect pixelArea;
        private Coord screenSize;
        private readonly Coord zeroCoord = new(0,0);
        private SafeFileHandle ConsoleOutput;
        /// <summary>
        /// The width of the screen, columns of chars
        /// </summary>
        public int ScreenWidth { get; private set; }
        /// <summary>
        /// The height of the screen, rows of chars
        /// </summary>
        public int ScreenHeight { get; private set; }

        private string title = "Console Game Engine";
        /// <summary>
        /// Sets the title of the Console Window
        /// </summary>
        public string Title { get { return title; } 
            set 
            {
                title = value;
                Console.Title = title;
            } 
        }

        private bool displayFps = true;
        /// <summary>
        /// Toggle if you want to display the FPS in the consoles title
        /// </summary>
        public bool DisplayFpsInTitle
        {
            get { return displayFps; }
            set
            {
                displayFps = value;
                if (!displayFps)
                {
                    Console.Title = title;
                }
            }
        }

        //Thread
        private bool isRunning;
        private bool consoleConstructed;

        private float fixedDeltaTime = 0.01f;

        /// <summary>
        /// Get and Set the fixed delta time in seconds
        /// </summary>
        public float FixedDeltaTime { 
            get { return fixedDeltaTime; }
            set { fixedDeltaTime = MathF.Min(value, 0.0f); }
        }

        //Inputs
        private IntPtr consoleHandle;

        bool[] currentKeyState = new bool[256];
        bool[] previousKeyState = new bool[256];
        bool[] currentMouseState = new bool[5];
        bool[] previousMouseState = new bool[5];

        protected int mouseX = 0;
        protected int mouseY = 0;
        /// <summary>
        /// Mouse Position, in char space, not screen pixels 
        /// </summary>
        public (int X, int Y) MousePos { get; private set; }


        /// <summary>
        /// Will create/rezize a console window with specified width and height. Can fail if size extends window borders, try smaller values.
        /// </summary>
        /// <param name="width">Number of columns</param>
        /// <param name="height">Number of rows</param>
        /// <param name="fontWidth">Width of the font, i.e. pixel width</param>
        /// <param name="fontHeight">Height of the font, i.e. pixel height</param>
        /// <exception cref="Exception">If it fails in any step</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public void ConstructConsole(int width, int height, int fontWidth = 5, int fontHeight = 5)
        {
            SafeFileHandle h = CreateFile("CONOUT$", 0x40000000, 2, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);

            if (!h.IsInvalid)
            {
                //do the sceen
                Console.SetWindowSize(1, 1); //shrink the window so we can set any shrink buffer size if needed
                Console.SetBufferSize(width, height); // buffer size

                ConsoleOutput = h;
                ScreenWidth = width;
                ScreenHeight = height;
                screenBuffer = new CharInfo[width * height];
                screenArea = new SmallRect() { Left = 0, Top = 0, Right = (short)width, Bottom = (short)height };
                screenSize = new Coord() { X = (short)width, Y = (short)height };


                //do the font
                PCONSOLE_FONT_INFOEX cfi = new()
                {
                    cbSize = (uint)Marshal.SizeOf(typeof(PCONSOLE_FONT_INFOEX)),
                    nFont = 0,
                    dwFontSize = new Coord((short)fontWidth, (short)fontHeight),
                    FontFamily = 0x00, //FF_DONTCARE
                    FontWeight = 400, //FW_NORMAL
                    FaceName = "Consolas"
                };

                bool setFont = SetCurrentConsoleFontEx(GetStdHandle(STD_OUTPUT_HANDLE), false, ref cfi);
                if (!setFont)
                {
                    throw new Exception("Setting font failed");
                }

                Console.SetWindowSize(width, height); //now set the window size once the font is in place
                


                SetupInput();
                Console.CursorVisible = false;
                consoleConstructed = true;
            }
            else
            {
                throw new Exception("Invalid Handle to Console");
            }
        }

        /// <summary>
        /// Start the game loop. You need to call ConstructConsole() first.
        /// </summary>
        /// <exception cref="Exception">If ConstructConsole is not called first</exception>
        public void Start()
        {
            if (!consoleConstructed)
            {
                throw new Exception("No Console Contructed");
            }
            isRunning = true;
            Thread thread = new(Run);
            thread.Start();
            thread.Join();  
        }

        /// <summary>
        /// Will exit the game loop and virtual OnExit will be called on the way
        /// </summary>
        public void Exit()
        {
            isRunning = false;
        }

        /// <summary>
        /// Called before the game loop starts to load and set up anything that needs to be initialized
        /// </summary>
        protected abstract void Initialize();

        /// <summary>
        /// Called every frame, deltaTime/dt is time since last frame in seconds
        /// </summary>
        /// <param name="deltaTime"></param>
        protected abstract void Update(float deltaTime);

        /// <summary>
        /// Called with a fixrd time interval
        /// </summary>
        /// <param name="deltaTime"></param>
        protected virtual void FixedUpdate() { }

        /// <summary>
        /// Called at the end once the game loop ends. Overrided if you need to do some clean up.
        /// </summary>
        protected virtual void OnExit() { }

        private void Run()
        {
            Initialize();

            DateTime currentTime = DateTime.Now;
            float lag = fixedDeltaTime;
            while (isRunning)
            {
                ProcessInput();

                DateTime newTime = DateTime.Now;
                TimeSpan frameTime = newTime - currentTime;
                currentTime = newTime;

                float deltaTime = (float)frameTime.TotalSeconds;
                lag += deltaTime;

                while (lag >= fixedDeltaTime)
                {
                    FixedUpdate();
                    lag -= fixedDeltaTime;
                }

                Update(deltaTime);
                
                if (DisplayFpsInTitle) { 
                    Console.Title = $"{title} - FPS: {1.0f / deltaTime:0.00}";      
                }
                bool b = WriteConsoleOutputW(ConsoleOutput, screenBuffer, screenSize, zeroCoord, ref screenArea);
                if (!b)
                {
                    Console.Clear();
                    Console.WriteLine("WriteConsoleOutputW returned false, I think that is an error, exiting the game loop.");
                    isRunning = false;
                }
            }
            OnExit();
        }

        private void SetupInput()
        {

            consoleHandle = GetStdHandle(STD_INPUT_HANDLE);

            uint mode = 0;
            if (!(GetConsoleMode(consoleHandle, ref mode))) { throw new Win32Exception(); }

            mode |= ENABLE_MOUSE_INPUT;
            mode &= ~ENABLE_QUICK_EDIT_MODE;
            mode |= ENABLE_EXTENDED_FLAGS;

            if (!(SetConsoleMode(consoleHandle, mode))) { throw new Win32Exception(); }

            //int len = Enum.GetNames(typeof(KeyCode)).Length;
            int len = 256;
            currentKeyState = new bool[len];
            previousKeyState = new bool[len];
        }

        //rewrite this, inputs missed if pressed and released within a frame
        private void ProcessInput()
        {
            INPUT_RECORD[] inputRecordBuffer = new INPUT_RECORD[32];
            uint nrOfEvents = 0;
            GetNumberOfConsoleInputEvents(consoleHandle, ref nrOfEvents);
            if(nrOfEvents > 0)
            {
                ReadConsoleInput(consoleHandle, inputRecordBuffer, nrOfEvents, ref nrOfEvents);
            }

            //reset the stuff
            for (int m = 0; m < currentMouseState.Length; m++)
            {
                previousMouseState[m] = currentMouseState[m];
            }
            for (int m = 0; m < currentKeyState.Length; m++)
            {
                previousKeyState[m] = currentKeyState[m];
            }

            //Collect the events
            for (int i = 0; i < nrOfEvents; i++)
            {
                switch (inputRecordBuffer[i].EventType)
                {
                    case INPUT_RECORD.MOUSE_EVENT:
                        if(inputRecordBuffer[i].MouseEvent.dwEventFlags == MOUSE_EVENT_RECORD.MOUSE_MOVED)
                        {
                            mouseX = inputRecordBuffer[i].MouseEvent.dwMousePosition.X;
                            mouseY = inputRecordBuffer[i].MouseEvent.dwMousePosition.Y;
                            MousePos = (mouseX, mouseY);
                        }
                        else if (inputRecordBuffer[i].MouseEvent.dwEventFlags == 0)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                //if(!currentMouseState[m])
                                currentMouseState[m] = (inputRecordBuffer[i].MouseEvent.dwButtonState & (1 << m)) > 0;
                            }
                        }
                        break;
                    case INPUT_RECORD.KEY_EVENT:
                        int key = inputRecordBuffer[i].KeyEvent.wVirtualKeyCode;
                        //previousKeyState[key] = currentKeyState[key];
                        currentKeyState[key] = inputRecordBuffer[i].KeyEvent.bKeyDown;
                        break;
                    default:
                        break;
                }
            }

            
        }


        /// <summary>
        /// Check if a specific key is down this frame
        /// </summary>
        /// <param name="key">KeyCode you want</param>
        /// <returns>true if the key is down this frame, else false</returns>
        public bool IsKeyDown(KeyCode key)
        {
            return currentKeyState[(int)key];
        }
        /// <summary>
        /// Check if a specific key was pressed this frame, will return to false if held
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true if the key is down this frame but not the one before, else false</returns>
        public bool KeyPressed(KeyCode key)
        {
            return currentKeyState[(int)key] && !previousKeyState[(int)key];
        }
        /// <summary>
        /// Check if a specific key was released this frame
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true if the key is up this frame but down the one before, else false</returns>
        public bool KeyReleased(KeyCode key)
        {
            return !currentKeyState[(int)key] && previousKeyState[(int)key];
        }

        /// <summary>
        /// Check if a mouse button is held this frame (0-5 or will throw IndexOutOfRangeException)
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if mouse button is down this frame, else false</returns>
        public bool MouseButtonDown(int num)
        {
            return currentMouseState[num];
        }
        /// <summary>
        /// Check if a mouse button was pressed this frame (0-5 or will throw IndexOutOfRangeException)
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if mouse button is down this frame but not the previous, else false</returns>
        public bool MouseButtonPressed(int num)
        {
            return currentMouseState[num] && !previousMouseState[num];
        }
        /// <summary>
        /// Check if a mouse button was released this frame (0-5 or will throw IndexOutOfRangeException)
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True if mouse button is up this frame but was down the previous, else false</returns>
        public bool MouseButtonReleased(int num)
        {
            return !currentMouseState[num] && previousMouseState[num];
        }
        /// <summary>
        /// Draws a char to the specific point on the screen, with color
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="c"></param>
        /// <param name="col"></param>
        public void Draw(int x, int y, ushort c = 0x2588, short col = 0x000F)
        {
            if (x >= 0 && x < ScreenWidth && y >= 0 && y < ScreenHeight)
            {
                screenBuffer[y * ScreenWidth + x].Char.UnicodeChar = c;
                screenBuffer[y * ScreenWidth + x].Attributes = col;
            }       
        }
        /// <summary>
        /// Will fill a rectangle on the screen, specified by top right and botom left corner
        /// </summary>
        /// <param name="x1">x coord of top left</param>
        /// <param name="y1">y coord of top left</param>
        /// <param name="x2">x coord of bottom right</param>
        /// <param name="y2">y coord of bottom right</param>
        /// <param name="c"></param>
        /// <param name="col"></param>
        public void FillRect(int x1, int y1, int x2, int y2, ushort c = 0x2588, short col = 0x000F)
        {
            ClampToScreen(ref x1, ref y1);
            ClampToScreen(ref x2, ref y2);
            for (int x = x1; x < x2; x++)
                for (int y = y1; y < y2; y++)
                    Draw(x, y, c, col);
        }

        /// <summary>
        /// Draws a cool line between two points. (x1, y1) and (x2, y2)
        /// </summary>
        /// <param name="x1">x coord of start point</param>
        /// <param name="y1">y coord of start point </param>
        /// <param name="x2">x coord of end point</param>
        /// <param name="y2">y coord of end point</param>
        /// <param name="c"></param>
        /// <param name="col"></param>
        public void DrawLine(int x1, int y1, int x2, int y2, ushort c = 0x2588, short col = 0x000F)
        {
            int x, y, dx, dy, dx1, dy1, px, py, xe, ye, i;
            dx = x2 - x1; 
            dy = y2 - y1;

            dx1 = Math.Abs(dx); 
            dy1 = Math.Abs(dy);

            px = 2 * dy1 - dx1; 
            py = 2 * dx1 - dy1;

            if (dy1 <= dx1)
            {
                if (dx >= 0)
                { 
                    x = x1; 
                    y = y1; 
                    xe = x2; 
                }
                else
                { 
                    x = x2; 
                    y = y2; 
                    xe = x1; 
                }

                Draw(x, y, c, col);

                for (i = 0; x < xe; i++)
                {
                    x = x + 1;
                    if (px < 0)
                    {
                        px = px + 2 * dy1;
                    }
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) y = y + 1; else y = y - 1;
                        px = px + 2 * (dy1 - dx1);
                    }
                    Draw(x, y, c, col);
                }
            }
            else
            {
                if (dy >= 0)
                { x = x1; y = y1; ye = y2; }
                else
                { x = x2; y = y2; ye = y1; }

                Draw(x, y, c, col);

                for (i = 0; y < ye; i++)
                {
                    y = y + 1;
                    if (py <= 0)
                    {
                        py = py + 2 * dx1;
                    }
                    else
                    {
                        if ((dx < 0 && dy < 0) || (dx > 0 && dy > 0)) x = x + 1; 
                        else x = x - 1;
                        py = py + 2 * (dx1 - dy1);
                    }
                    Draw(x, y, c, col);
                }
            }
        }

        public void DrawString(int x, int y, string text, short col = 0x000F)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Draw(x+i, y, text[i], col);
            }
        }

        public void ClampToScreen(ref int x, ref int y)
        {
            if (x < 0) x = 0;
            if (x >= ScreenWidth) x = ScreenWidth;
            if (y < 0) y = 0;
            if (y >= ScreenHeight) y = ScreenHeight;
        }

    }

    /// <summary>
    /// Native calls to Kernel32.dll and some stuff
    /// </summary>
    internal static class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct Coord
        {
            public short X;
            public short Y;

            internal Coord(short X, short Y)
            {
                this.X = X;
                this.Y = Y;
            }
        };

        [StructLayout(LayoutKind.Explicit)]
        internal struct INPUT_RECORD
        {
            internal const ushort KEY_EVENT = 0x0001,
                MOUSE_EVENT = 0x0002,
                WINDOW_BUFFER_SIZE_EVENT = 0x0004,
                FOCUS_EVENT = 0x0010;

            [FieldOffset(0)]
            internal ushort EventType;
            [FieldOffset(4)]
            internal KEY_EVENT_RECORD KeyEvent;
            [FieldOffset(4)]
            internal MOUSE_EVENT_RECORD MouseEvent;
            [FieldOffset(4)]
            internal WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;
            /*
            and:
             MENU_EVENT_RECORD MenuEvent;
             FOCUS_EVENT_RECORD FocusEvent;
             */
        }

        internal struct MOUSE_EVENT_RECORD
        {
            public Coord dwMousePosition;

            public const uint FROM_LEFT_1ST_BUTTON_PRESSED = 0x0001,
                FROM_LEFT_2ND_BUTTON_PRESSED = 0x0004,
                FROM_LEFT_3RD_BUTTON_PRESSED = 0x0008,
                FROM_LEFT_4TH_BUTTON_PRESSED = 0x0010,
                RIGHTMOST_BUTTON_PRESSED = 0x0002;
            public uint dwButtonState;

            public const int CAPSLOCK_ON = 0x0080,
                ENHANCED_KEY = 0x0100,
                LEFT_ALT_PRESSED = 0x0002,
                LEFT_CTRL_PRESSED = 0x0008,
                NUMLOCK_ON = 0x0020,
                RIGHT_ALT_PRESSED = 0x0001,
                RIGHT_CTRL_PRESSED = 0x0004,
                SCROLLLOCK_ON = 0x0040,
                SHIFT_PRESSED = 0x0010;
            public uint dwControlKeyState;

            public const int DOUBLE_CLICK = 0x0002,
                MOUSE_HWHEELED = 0x0008,
                MOUSE_MOVED = 0x0001,
                MOUSE_WHEELED = 0x0004;
            public uint dwEventFlags;
        }

        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        internal struct KEY_EVENT_RECORD
        {
            [FieldOffset(0)]
            public bool bKeyDown;
            [FieldOffset(4)]
            public ushort wRepeatCount;
            [FieldOffset(6)]
            public ushort wVirtualKeyCode;
            [FieldOffset(8)]
            public ushort wVirtualScanCode;
            [FieldOffset(10)]
            public char UnicodeChar;
            [FieldOffset(10)]
            public byte AsciiChar;

            public const int CAPSLOCK_ON = 0x0080,
                ENHANCED_KEY = 0x0100,
                LEFT_ALT_PRESSED = 0x0002,
                LEFT_CTRL_PRESSED = 0x0008,
                NUMLOCK_ON = 0x0020,
                RIGHT_ALT_PRESSED = 0x0001,
                RIGHT_CTRL_PRESSED = 0x0004,
                SCROLLLOCK_ON = 0x0040,
                SHIFT_PRESSED = 0x0010;
            [FieldOffset(12)]
            public uint dwControlKeyState;
        }

        internal struct WINDOW_BUFFER_SIZE_RECORD
        {
            public Coord dwSize;
        }

        internal const uint STD_INPUT_HANDLE = unchecked((uint)-10),
                            STD_OUTPUT_HANDLE = unchecked((uint)-11),
                            STD_ERROR_HANDLE = unchecked((uint)-12);

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetStdHandle(uint nStdHandle);


        internal const uint ENABLE_MOUSE_INPUT = 0x0010,
                            ENABLE_QUICK_EDIT_MODE = 0x0040,
                            ENABLE_EXTENDED_FLAGS = 0x0080,
                            ENABLE_ECHO_INPUT = 0x0004,
                            ENABLE_WINDOW_INPUT = 0x0008; //more

        [DllImport("kernel32.dll")]
        internal static extern bool GetConsoleMode(IntPtr hConsoleInput, ref uint lpMode);

        [DllImport("kernel32.dll")]
        internal static extern bool SetConsoleMode(IntPtr hConsoleInput, uint dwMode);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref uint NumberOfEvents);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool ReadConsoleInput(IntPtr hConsoleInput, [Out] INPUT_RECORD[] lpBuffer, uint nLength, ref uint lpNumberOfEventsRead);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        internal static extern bool WriteConsoleInput(IntPtr hConsoleInput, INPUT_RECORD[] lpBuffer, uint nLength, ref uint lpNumberOfEventsWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, ref PCONSOLE_FONT_INFOEX lpConsoleCurrentFontEx);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct PCONSOLE_FONT_INFOEX
        {
            public uint cbSize;
            public uint nFont;
            public Coord dwFontSize;
            public int FontFamily;
            public int FontWeight;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] // Edit sizeconst if the font name is too big - 32 is LF_FACESIZE
            public string FaceName;
        }

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern SafeFileHandle CreateFile(
            string fileName,
            [MarshalAs(UnmanagedType.U4)] uint fileAccess,
            [MarshalAs(UnmanagedType.U4)] uint fileShare,
            IntPtr securityAttributes,
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] int flags,
            IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool WriteConsoleOutputW(
          SafeFileHandle hConsoleOutput,
          CharInfo[] lpBuffer,
          Coord dwBufferSize,
          Coord dwBufferCoord,
          ref SmallRect lpWriteRegion);

        [StructLayout(LayoutKind.Explicit)]
        public struct CharUnion
        {
            [FieldOffset(0)] public ushort UnicodeChar;
            [FieldOffset(0)] public byte AsciiChar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct CharInfo
        {
            [FieldOffset(0)] public CharUnion Char;
            [FieldOffset(2)] public short Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SmallRect
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }
    }
}

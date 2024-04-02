/*

    IM NOT SURE WHAT TO LEAVE OUT IN THIS FILE

*/

using System.Media;

namespace StartScreenSample
{
    public partial class frmLvl1 : Form
    {
        public frmLvl1()
        {
            InitializeComponent();
            InitializeSound();
        }

        List<PictureBox> explosions;

        private List<PictureBox> lasers;

        private SoundPlayer music = new SoundPlayer();
        private SoundPlayer count = new SoundPlayer();
        private SoundPlayer go = new SoundPlayer();
        private SoundPlayer gameOver = new SoundPlayer();

        private void InitializeSound()
        {
            
        }

        private const int pos1 = 36, pos2 = 132, pos3 = 227, pos4 = 323, pos5 = 420, pos6 = 515, pos7 = 611, pos8 = 708, pos9 = 804;
        private bool active = false;

        private int cd = 5;

        

        

        private int currentPos = 5;
    }
}

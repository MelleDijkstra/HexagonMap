using System;
using System.Windows.Forms;

namespace HexagonMap
{
    public partial class MainWindow : Form
    {
        Game game;

        public static int WIDTH;
        public static int HEIGHT;

        public MainWindow()
        {
            InitializeComponent();
            WIDTH = ClientSize.Width;
            HEIGHT = ClientSize.Height;
            game = new Game();
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void theLoop_Tick(object sender, System.EventArgs e)
        {
            // Updating the Form
            game.Update();

            // Then invalidate
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            WIDTH = ClientSize.Width;
            HEIGHT = ClientSize.Height;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            game.refreshMap();
        }
    }
}

using System.Drawing;

namespace HexagonMap
{
    internal class Game
    {
        private Map instance;

        public Map map => instance ?? (instance = new Map(MainWindow.WIDTH, MainWindow.HEIGHT));

        public Game()
        {

        }

        public void Draw(Graphics g)
        {
            map.Draw(g);
        }

        public void Update()
        {

        }

        public void refreshMap()
        {
            map.SetWidth(MainWindow.WIDTH);
            map.SetHeight(MainWindow.HEIGHT);
            map.Refresh();
        }
    }
}
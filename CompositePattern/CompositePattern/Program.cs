using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IExplorer root = new Folder("root");
                IExplorer user = new Folder("user");
                IExplorer temp = new Folder("temp");
                IExplorer documents = new Folder("document");
                IExplorer game = new Folder("げぇむ");

                IExplorer gomi = new File("ごみ");
                IExplorer ika = new File("ika");
                IExplorer tako = new File("tako");
                IExplorer salmon = new File("salmon");

                //フォルダを追加
                root.AddComponent(user);
                root.AddComponent(temp);
                user.AddComponent(documents);
                user.AddComponent(game);

                //ファイルを追加
                temp.AddComponent(gomi);
                game.AddComponent(ika);
                game.AddComponent(tako);
                game.AddComponent(salmon);

                root.Output(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Exceptionが発生しました");
            }
        }
    }
}

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
                IEntry root = new Folder("root");
                IEntry user = new Folder("user");
                IEntry temp = new Folder("temp");
                IEntry documents = new Folder("document");
                IEntry game = new Folder("げぇむ");

                IEntry gomi = new File("ごみ");
                IEntry ika = new File("ika");
                IEntry tako = new File("tako");
                IEntry salmon = new File("salmon");

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

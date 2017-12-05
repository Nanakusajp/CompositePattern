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
                var root = new Folder("root");
                var user = new Folder("user");
                var temp = new Folder("temp");
                var documents = new Folder("document");
                var game = new Folder("げぇむ");

                var gomi = new File("ごみ");
                var ika = new File("ika");
                var tako = new File("tako");
                var salmon = new File("salmon");

                //フォルダを追加
                root.AddEntry(user);
                root.AddEntry(temp);
                user.AddEntry(documents);
                user.AddEntry(game);

                //ファイルを追加
                temp.AddEntry(gomi);
                game.AddEntry(ika);
                game.AddEntry(tako);
                game.AddEntry(salmon);

                root.Output(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Exceptionが発生しました");
            }
        }
    }
}

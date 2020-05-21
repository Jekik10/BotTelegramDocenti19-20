using System;

namespace TelegramBot {

    public static class Ut{
        public static string GetClasse(string id)
        {
            string classe;
            try
            {
                using (Database dbContext = new Database())
                {
                    var s = dbContext.Studenti.Find(Convert.ToInt32(id));
                    classe = s.Classe;
                }
            }
            catch
            {
                classe = "Non nel DB";
            }

            return classe;
        }

        public static bool StudenteEsiste(string id)
        {
            bool flag = true;
            using (Database dbContext = new Database())
            {
                var list = dbContext.Studenti.Find(Convert.ToInt32(id));
                if (list == null)
                    flag = false;
            }
            return flag;
        }

    }
}
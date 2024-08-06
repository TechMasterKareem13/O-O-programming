using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_O_programming
{
    internal class VideoGame
    {
        private string id;
        public string name;
        public string publisher;
        public string rating;
    
        internal VideoGame(string Name, string Publisher, string Rating)
        {
            name = Name;    
            publisher = Publisher;  
            rating = Rating;

            GenerateNewId();
        }

        private void GenerateNewId()
        {
            id = Guid.NewGuid().ToString();
        }
        

        

    }

   
}

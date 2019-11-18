using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tajinder_dog_race
{
    public class ground
    {
        //instance object of the class that is used to genreate the random for the jump
        Random obj_rnd = new Random();

        //user define method that is used to grenerate the random no for jump 
        public int jump() {
            return obj_rnd.Next(1, 50);
        }

        //this method is used to pass the updated budget and pass to the main method 
        public int show_Result(String data,int winner,int budget) {
            //array to filter the details 
            String[] filter = data.Split('-');
            if (Convert.ToInt32(filter[1]) == winner)
            {
                return Convert.ToInt32(filter[2]) + budget;
            }
            else {
                return  budget- Convert.ToInt32(filter[2]);
            }

        }



    }
}

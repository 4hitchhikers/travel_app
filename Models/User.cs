using System;
using System.Collections.Generic;



namespace travel_app.Models
{
    public class User
    {

        public int userid { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string profile_pict { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<Place> visited { get; set; }
        public List<Picture> uploaded { get; set; }
        public List<Comment> my_comments { get; set; }


        public User()
        {
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            visited = new List<Place>();
            uploaded = new List<Picture>();
            my_comments = new List<Comment>();
        }
    }
}


        // public string order_duration {
        //     get{
        //         double dur = DateTime.Now.Subtract(this.created_at).TotalMinutes;
        //         string final_word = "minute(s)";
        //         if((int)dur >= 60)
        //         {
        //             dur = DateTime.Now.Subtract(this.created_at).TotalHours;
        //             final_word = "hour(s)";
        //         }
        //         else if(dur >= 24)
        //         {
        //             dur = DateTime.Now.Subtract(this.created_at).TotalDays;
        //             final_word = "day(s)";
        //         }
        //         else if(dur >= 7)
        //         {
        //             dur = DateTime.Now.Subtract(this.created_at).TotalDays/7;
        //             final_word = "week(s)";
        //         }
        //         return $"{(int)dur} {final_word} ago";
        //     }
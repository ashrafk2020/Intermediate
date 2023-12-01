using System.Threading;
using System;
namespace Intermediate  

{
    class Post
    {
        private string title;
        private string description;
        private DateTime timeCreated;
        private int voteValue;


        public Post(string title,string description)
        {
            this.timeCreated = DateTime.Now;
            this.title = title;
            this.description = description;

        }

        public void UpVote()
        {
            voteValue ++;
        }

        public void DownVote()
        {
            voteValue --;
            if(voteValue <0)
            {
                voteValue = 0;
            }
        }

        public int GetVoteValue()
        {
            return voteValue;
        }
        public string GetCreateDate()
        {
            return timeCreated.ToShortTimeString();
        }
        


    }
}
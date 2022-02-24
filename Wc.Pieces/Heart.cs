using System;

namespace Wc.Pieces
{
    public class Heart: PieceBase
    {

        
        
        
        public string Says = "";
        public HeartSong State;
        private Body Owner = null;
        private Body Current = null;
        
        public Heart(Body owner)
        {
            
        }

        public override void Think()
        {




            base.Think();
        }


        public void Mute(bool muted)
        {

        }

        public virtual HeartSong Send(int id, int song = 1)
        {
            //get body by id

            //check heart song.

            //if song = closed, done
            //if song = open, heartset add
            //if song = broken, sing along, for count of song

            return HeartSong.Open;
        }

        public virtual string Receive(Heart heart, )
        {
            
        }

        

    }

    public enum HeartSong
    {
        Open,
        Closed,
        Broken,
        InLove
    }
}

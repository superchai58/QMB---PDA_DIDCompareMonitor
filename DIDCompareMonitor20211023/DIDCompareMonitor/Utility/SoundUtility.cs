using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DIDCompareMonitor.Utility
{
    public enum MessageLevel
    {
        Pass,
        Error,
        Warning,
        Init
    }

    public class SoundUtility
    {
        public static void Sound(MessageLevel level)
        {
            SoundPlayer player = new SoundPlayer();

            if (level == MessageLevel.Error)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"\Resources\OO.wav";
            }
            else
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"\Resources\OK.wav";
            }

            player.Play();
        }
    }
}

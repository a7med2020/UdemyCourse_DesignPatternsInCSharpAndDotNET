using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.StructuralPatterns._6Adapter.More
{
    public interface MediaPlayer
    {
        public void play(String audioType, String fileName);
    }

    public interface AdvancedMediaPlayer
    {
        public void playVlc(String fileName);
        public void playMp4(String fileName);
    }

    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void playVlc(String fileName)
        {
            Write("Playing vlc file. Name: " + fileName);
        }

        public void playMp4(String fileName)
        {
            //do nothing
        }
    }

    public class Mp4Player : AdvancedMediaPlayer
    {

        public void playVlc(String fileName)
        {
            //do nothing
        }

        public void playMp4(String fileName)
        {
            Write("Playing mp4 file. Name: " + fileName);
        }
    }

    public class MediaAdapter : MediaPlayer
    {

        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(String audioType)
        {

            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }


        public void play(String audioType, String fileName)
        {

            if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }


    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(String audioType, String fileName)
        {

            //inbuilt support to play mp3 music files
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Write("Playing mp3 file. Name: " + fileName);
            }
            //mediaAdapter is providing support to play other file formats
            else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Write("Invalid media. " + audioType + " format not supported");
            }
        }
    }

    class MediaPlayerExample
    {
        public static void Execute()
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.play("mp3", "beyond the horizon.mp3");
            audioPlayer.play("mp4", "alone.mp4");
            audioPlayer.play("vlc", "far far away.vlc");
            audioPlayer.play("avi", "mind me.avi");
        }
    }
}

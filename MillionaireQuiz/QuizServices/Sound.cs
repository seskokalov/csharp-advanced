using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace QuizServices
{
    public static class Sound
    {
        public static SoundPlayer ContestantName() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\ContestantName.wav");
        public static SoundPlayer Rules() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\Rules.wav");
        public static SoundPlayer FinalAnswer() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\FinalAnswer.wav");
        public static SoundPlayer Question() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\Question.wav");
        public static SoundPlayer LetsPlay() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\LetsPlay.wav");
        public static SoundPlayer GoodAnswer() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\GoodAnswer.wav");
        public static SoundPlayer WrongAnswer() => new SoundPlayer(@"..\..\..\..\QuizServices\SoundFiles\WrongAnswer.wav");
    }
}

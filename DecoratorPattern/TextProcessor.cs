using System;

namespace Lab7Patterns.DecoratorPattern
{
    public static class TextProcessor
    {
        public static Func<string, string> AddHeader(Func<string, string> processor)
        {
            return new Func<string, string>((input) => AddHeaderImpl(processor, input));
        }

        public static Func<string, string> AddFooter(Func<string, string> processor)
        {
            return new Func<string, string>((input) => AddFooterImpl(processor, input));
        }

        public static Func<string, string> MakeUpper(Func<string, string> processor)
        {
            return new Func<string, string>((input) => MakeUpperImpl(processor, input));
        }


        private static string AddHeaderImpl(Func<string, string> processor, string input)
        {
            return "[Header]\n" + processor(input);
        }

        private static string AddFooterImpl(Func<string, string> processor, string input)
        {
            return processor(input) + "\n[Footer]";
        }

        private static string MakeUpperImpl(Func<string, string> processor, string input)
        {
            return processor(input).ToUpper();
        }
    }
}

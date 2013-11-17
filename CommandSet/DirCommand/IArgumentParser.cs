namespace CommandSet.DirCommand
{
   public interface IArgumentParser
   {
      RunSettings Parse( string[] arguments );
   }
}

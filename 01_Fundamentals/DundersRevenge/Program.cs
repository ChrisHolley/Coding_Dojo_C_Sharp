using System;

namespace DundersRevenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Human Dunder = new Human("Dunder", 49, 9001, -1, 200);
            int stage = 0;
            IntroSplash.intro();
            Console.ForegroundColor = ConsoleColor.DarkRed; 

            Console.Clear();
            Console.WriteLine(@"           .                                                 ,;           
          ;W                                    .Gt        f#i            
         f#E  GEEEEEEEL             ..         j#W:      .E#t             
       .E#f   ,;;L#K;;.            ;W,       ;K#f       i#W,            jt
      iWW;       t#E              j##,     .G#D.       L#D.            G#t
     L##Lffi     t#E             G###,    j#K;       :K#Wfff;          E#t
    tLLG##L      t#E           :E####,  ,K#f   ,GD;  i##WLLLLt         E#t
      ,W#i       t#E          ;W#DG##,   j#Wi   E#t   .E#L             E#t
     j#E.        t#E         j###DW##,    .G#D: E#t     f#E:           E#t
   .D#j          t#E        G##i,,G##,      ,K#fK#t      ,WW;          E#t
  ,WK,           t#E      :K#K:   L##,        j###t       .D#;         E#t
  EG.             fE     ;##D.    L##,         .G#t         tt         tf,
  ,                :     ,,,      .,,            ;;                       ");
              Console.ForegroundColor = ConsoleColor.White; 

            while (Dunder.Health > 0){
                Stages.stage(stage, Dunder);
                stage++;
                

            }
        }
    }
}

// public class Rombs : FigureDraw
// {   

//     private int SideLength;

//     public Rombs(int sides, int SideLength){
//         this.SideLength = SideLength;
//     }
//     public Rombs(){
//         SideLength = 4;
//     }
//     public override void Draw()
//     {
//         Console.WriteLine("\nZīmē rombu:");
//         Console.WriteLine();
//         for (int i = 0; i < SideLength; i++)
//         {
//             for (int j = SideLength - i; j > 0; j--)
//             {
//                 Console.Write(" ");
//             }
//             for (int j = 0; j <= i; j++)
//             {
//                 Console.Write("* ");
//             }
//             Console.WriteLine();
//         }
//         for (int i = SideLength; i >= 0; i--)
//         {
//             for (int j = SideLength - i; j > 0; j--)
//             {
//                 Console.Write(" ");
//             }
//             for (int j = 0; j <= i; j++)
//             {
//                 Console.Write("* ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

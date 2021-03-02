using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Creator
{
    class Borders
    {
        public static int[] cols;

        public static string UpperLeft_Corner = "╔";
        public static string UpperRight_Corner = "╗";
        public static string MiddleLine = "═";

        public static string MiddleDownLine = "╦";
        public static string MiddleUpLine = "╩";
        public static string MiddleEdge = "║";
        public static string Cross = "╬";
        public static string LeftLineLeft = "╠";
        public static string RightLineRight = "╣";
                
        public static string BottomLeft_Corner = "╚";
        public static string BottomRight_Corner = "╝";
    }

    class Creator
    {
        public static void set_columns(int[] cols)
        {
            Borders.cols = cols;
        }

        public static string createHeader(string[] col_value)
        {
            if (Borders.cols.Length != col_value.Length) return "Error, Invalid Argument Count!";
            string first_line = Borders.UpperLeft_Corner;
            string last_line = Borders.LeftLineLeft;
            foreach(int colsz in Borders.cols)
            {
                for(int i = 0; i < colsz; i++)
                {
                    first_line += Borders.MiddleLine;
                    last_line += Borders.MiddleLine;
                }
                first_line += Borders.MiddleDownLine;
                last_line += Borders.Cross;
            }
            first_line += Borders.UpperRight_Corner;
            last_line += Borders.RightLineRight;

            string middle_line = Borders.MiddleEdge;

            int new_c = 0;
            string results = "";
            int n = 0;
            foreach(string colzs in col_value)
            {
                int cln_sz = Borders.cols[new_c]-2;
                if(colzs.Length < cln_sz)
                {
                    int spaces = cln_sz - colzs.Length;
                    middle_line += " " + colzs + makeSpace(spaces) + Borders.MiddleEdge;
                }
                new_c++;
            }
            return first_line.Replace("╦╗", Borders.UpperRight_Corner) + "\r\n" + middle_line + "\r\n" + last_line.Replace("╬╣", Borders.RightLineRight);
        }

        public static string CreateRow(string[] row_value)
        {
            string replyRow = Borders.MiddleEdge;
            int new_c = 0;
            foreach(string cln_str in row_value)
            {
                int row_length = Borders.cols[new_c]-2;
                if(cln_str.Length < row_length)
                {
                    int spaces = row_length - cln_str.Length;
                    replyRow += " " + cln_str + makeSpace(spaces) + Borders.MiddleEdge;
                }
                new_c++;
            }

            return replyRow;
        }

        public static string makeSpace(int spaces)
        {
            string spcs = "";
            for(int i = 0; i <= spaces; i++)
            {
                spcs += " ";
            }
            return spcs;
        }

        public static string createFooter()
        {
            string first_line = Borders.UpperLeft_Corner;
            string last_line = Borders.BottomLeft_Corner;
            foreach (int colsz in Borders.cols)
            {
                for (int i = 0; i < colsz; i++)
                {
                    last_line += Borders.MiddleLine;
                }
                last_line += Borders.MiddleUpLine;
            }
            last_line += Borders.BottomRight_Corner;

            
            return last_line.Replace("╩╝", Borders.BottomRight_Corner) + "\r\n";
        }
    }
}

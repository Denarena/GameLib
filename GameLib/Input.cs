using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLib
{
    public class Input
    {

        public static bool Q, W, E, R, T, Y, U, I, O, P, A, S, D, F, G, H, J, K, L, Z, X, C, V, B, N, M, UP, DOWN, LEFT, RIGHT, ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, ZERO;

        internal static void GetKeyUp()
        {
            if (Game.KeyPresses == Keys.D0) { ZERO = false; }
            if (Game.KeyPresses == Keys.D1) { ONE = false; }
            if (Game.KeyPresses == Keys.D2) { TWO = false; }
            if (Game.KeyPresses == Keys.D3) { THREE = false; }
            if (Game.KeyPresses == Keys.D4) { FOUR = false; }
            if (Game.KeyPresses == Keys.D5) { FIVE = false; }
            if (Game.KeyPresses == Keys.D6) { SIX = false; }
            if (Game.KeyPresses == Keys.D7) { SEVEN = false; }
            if (Game.KeyPresses == Keys.D8) { EIGHT = false; }
            if (Game.KeyPresses == Keys.D9) { NINE = false; }

            if (Game.KeyPresses == Keys.Up) { UP = false; }
            if (Game.KeyPresses == Keys.Down) { DOWN = false; }
            if (Game.KeyPresses == Keys.Left) { LEFT = false; }
            if (Game.KeyPresses == Keys.Right) { RIGHT = false; }

            if (Game.KeyPresses == Keys.Q) { Q = false; }
            if (Game.KeyPresses == Keys.W) { W = false; }
            if (Game.KeyPresses == Keys.E) { E = false; }
            if (Game.KeyPresses == Keys.R) { R = false; }
            if (Game.KeyPresses == Keys.T) { T = false; }
            if (Game.KeyPresses == Keys.Y) { Y = false; }
            if (Game.KeyPresses == Keys.U) { U = false; }
            if (Game.KeyPresses == Keys.I) { I = false; }
            if (Game.KeyPresses == Keys.O) { O = false; }
            if (Game.KeyPresses == Keys.Q) { P = false; }
            if (Game.KeyPresses == Keys.A) { A = false; }
            if (Game.KeyPresses == Keys.S) { S = false; }
            if (Game.KeyPresses == Keys.D) { D = false; }
            if (Game.KeyPresses == Keys.F) { F = false; }
            if (Game.KeyPresses == Keys.G) { G = false; }
            if (Game.KeyPresses == Keys.H) { H = false; }
            if (Game.KeyPresses == Keys.J) { J = false; }
            if (Game.KeyPresses == Keys.K) { K = false; }
            if (Game.KeyPresses == Keys.L) { L = false; }
            if (Game.KeyPresses == Keys.Z) { Z = false; }
            if (Game.KeyPresses == Keys.X) { X = false; }
            if (Game.KeyPresses == Keys.C) { C = false; }
            if (Game.KeyPresses == Keys.V) { V = false; }
            if (Game.KeyPresses == Keys.B) { B = false; }
            if (Game.KeyPresses == Keys.N) { N = false; }
            if (Game.KeyPresses == Keys.M) { M = false; }
        }

        internal static void GetKeyDown()
        {
            if (Game.KeyPresses == Keys.Q) { Q = true; }
            if (Game.KeyPresses == Keys.W) { W = true; }
            if (Game.KeyPresses == Keys.E) { E = true; }
            if (Game.KeyPresses == Keys.R) { R = true; }
            if (Game.KeyPresses == Keys.T) { T = true; }
            if (Game.KeyPresses == Keys.Y) { Y = true; }
            if (Game.KeyPresses == Keys.U) { U = true; }
            if (Game.KeyPresses == Keys.I) { I = true; }
            if (Game.KeyPresses == Keys.O) { O = true; }
            if (Game.KeyPresses == Keys.Q) { P = true; }
            if (Game.KeyPresses == Keys.A) { A = true; }
            if (Game.KeyPresses == Keys.S) { S = true; }
            if (Game.KeyPresses == Keys.D) { D = true; }
            if (Game.KeyPresses == Keys.F) { F = true; }
            if (Game.KeyPresses == Keys.G) { G = true; }
            if (Game.KeyPresses == Keys.H) { H = true; }
            if (Game.KeyPresses == Keys.J) { J = true; }
            if (Game.KeyPresses == Keys.K) { K = true; }
            if (Game.KeyPresses == Keys.L) { L = true; }
            if (Game.KeyPresses == Keys.Z) { Z = true; }
            if (Game.KeyPresses == Keys.X) { X = true; }
            if (Game.KeyPresses == Keys.C) { C = true; }
            if (Game.KeyPresses == Keys.V) { V = true; }
            if (Game.KeyPresses == Keys.B) { B = true; }
            if (Game.KeyPresses == Keys.N) { N = true; }
            if (Game.KeyPresses == Keys.M) { M = true; }

            if (Game.KeyPresses == Keys.D0) { ZERO = true; }
            if (Game.KeyPresses == Keys.D1) { ONE = true; }
            if (Game.KeyPresses == Keys.D2) { TWO = true; }
            if (Game.KeyPresses == Keys.D3) { THREE = true; }
            if (Game.KeyPresses == Keys.D4) { FOUR = true; }
            if (Game.KeyPresses == Keys.D5) { FIVE = true; }
            if (Game.KeyPresses == Keys.D6) { SIX = true; }
            if (Game.KeyPresses == Keys.D7) { SEVEN = true; }
            if (Game.KeyPresses == Keys.D8) { EIGHT = true; }
            if (Game.KeyPresses == Keys.D9) { NINE = true; }

            if (Game.KeyPresses == Keys.Up) { UP = true; }
            if (Game.KeyPresses == Keys.Down) { DOWN = true; }
            if (Game.KeyPresses == Keys.Left) { LEFT = true; }
            if (Game.KeyPresses == Keys.Right) { RIGHT = true; }
        }
    }
}

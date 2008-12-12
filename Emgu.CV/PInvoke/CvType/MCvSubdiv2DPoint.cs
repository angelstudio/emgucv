﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Emgu.CV
{
   /// <summary>
   /// Managed CvSubdiv2DPoint structure
   /// </summary>
   [StructLayout(LayoutKind.Sequential)]
   public struct MCvSubdiv2DPoint
   {
      /// <summary>
      /// If -1, this point is invalid;
      /// If 1&gt;&gt;30, this point is a virtual point;
      /// </summary>
      public int flags;

      /// <summary>
      /// 
      /// </summary>
      public MCvSubdiv2DEdge first;
      /// <summary>
      /// 
      /// </summary>
      public MCvPoint2D32f pt;

      /// <summary>
      /// return if this is a valid point
      /// </summary>
      public bool IsValid
      {
         get
         {
            return flags != -1;
         }
      }
   }
}

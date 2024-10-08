﻿// Decompiled with JetBrains decompiler
// Type: ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants
// Assembly: SWPS4MAX, Version=1.0.7646.26709, Culture=neutral, PublicKeyToken=null
// MVID: 185BF9ED-B762-4AE8-B9E6-BAC5BF775B8B
// Assembly location: C:\Program Files (x86)\DataPower\Save Wizard for PS4 MAX\SWPS4MAX.exe

using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
  public class DeflaterConstants
  {
    public const bool DEBUGGING = false;
    public const int STORED_BLOCK = 0;
    public const int STATIC_TREES = 1;
    public const int DYN_TREES = 2;
    public const int PRESET_DICT = 32;
    public const int DEFAULT_MEM_LEVEL = 8;
    public const int MAX_MATCH = 258;
    public const int MIN_MATCH = 3;
    public const int MAX_WBITS = 15;
    public const int WSIZE = 32768;
    public const int WMASK = 32767;
    public const int HASH_BITS = 15;
    public const int HASH_SIZE = 32768;
    public const int HASH_MASK = 32767;
    public const int HASH_SHIFT = 5;
    public const int MIN_LOOKAHEAD = 262;
    public const int MAX_DIST = 32506;
    public const int PENDING_BUF_SIZE = 65536;
    public static int MAX_BLOCK_SIZE = Math.Min((int) ushort.MaxValue, 65531);
    public const int DEFLATE_STORED = 0;
    public const int DEFLATE_FAST = 1;
    public const int DEFLATE_SLOW = 2;
    public static int[] GOOD_LENGTH = new int[10]
    {
      0,
      4,
      4,
      4,
      4,
      8,
      8,
      8,
      32,
      32
    };
    public static int[] MAX_LAZY = new int[10]
    {
      0,
      4,
      5,
      6,
      4,
      16,
      16,
      32,
      128,
      258
    };
    public static int[] NICE_LENGTH = new int[10]
    {
      0,
      8,
      16,
      32,
      16,
      32,
      128,
      128,
      258,
      258
    };
    public static int[] MAX_CHAIN = new int[10]
    {
      0,
      4,
      8,
      32,
      16,
      32,
      128,
      256,
      1024,
      4096
    };
    public static int[] COMPR_FUNC = new int[10]
    {
      0,
      1,
      1,
      1,
      1,
      2,
      2,
      2,
      2,
      2
    };
  }
}

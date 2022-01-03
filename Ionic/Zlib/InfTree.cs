﻿// Decompiled with JetBrains decompiler
// Type: Ionic.Zlib.InfTree
// Assembly: SWPS4MAX, Version=1.0.7646.26709, Culture=neutral, PublicKeyToken=null
// MVID: 185BF9ED-B762-4AE8-B9E6-BAC5BF775B8B
// Assembly location: C:\Program Files (x86)\DataPower\Save Wizard for PS4 MAX\SWPS4MAX.exe

using System;

namespace Ionic.Zlib
{
  internal sealed class InfTree
  {
    private const int MANY = 1440;
    private const int Z_OK = 0;
    private const int Z_STREAM_END = 1;
    private const int Z_NEED_DICT = 2;
    private const int Z_ERRNO = -1;
    private const int Z_STREAM_ERROR = -2;
    private const int Z_DATA_ERROR = -3;
    private const int Z_MEM_ERROR = -4;
    private const int Z_BUF_ERROR = -5;
    private const int Z_VERSION_ERROR = -6;
    internal const int fixed_bl = 9;
    internal const int fixed_bd = 5;
    internal static readonly int[] fixed_tl = new int[1536]
    {
      96,
      7,
      256,
      0,
      8,
      80,
      0,
      8,
      16,
      84,
      8,
      115,
      82,
      7,
      31,
      0,
      8,
      112,
      0,
      8,
      48,
      0,
      9,
      192,
      80,
      7,
      10,
      0,
      8,
      96,
      0,
      8,
      32,
      0,
      9,
      160,
      0,
      8,
      0,
      0,
      8,
      128,
      0,
      8,
      64,
      0,
      9,
      224,
      80,
      7,
      6,
      0,
      8,
      88,
      0,
      8,
      24,
      0,
      9,
      144,
      83,
      7,
      59,
      0,
      8,
      120,
      0,
      8,
      56,
      0,
      9,
      208,
      81,
      7,
      17,
      0,
      8,
      104,
      0,
      8,
      40,
      0,
      9,
      176,
      0,
      8,
      8,
      0,
      8,
      136,
      0,
      8,
      72,
      0,
      9,
      240,
      80,
      7,
      4,
      0,
      8,
      84,
      0,
      8,
      20,
      85,
      8,
      227,
      83,
      7,
      43,
      0,
      8,
      116,
      0,
      8,
      52,
      0,
      9,
      200,
      81,
      7,
      13,
      0,
      8,
      100,
      0,
      8,
      36,
      0,
      9,
      168,
      0,
      8,
      4,
      0,
      8,
      132,
      0,
      8,
      68,
      0,
      9,
      232,
      80,
      7,
      8,
      0,
      8,
      92,
      0,
      8,
      28,
      0,
      9,
      152,
      84,
      7,
      83,
      0,
      8,
      124,
      0,
      8,
      60,
      0,
      9,
      216,
      82,
      7,
      23,
      0,
      8,
      108,
      0,
      8,
      44,
      0,
      9,
      184,
      0,
      8,
      12,
      0,
      8,
      140,
      0,
      8,
      76,
      0,
      9,
      248,
      80,
      7,
      3,
      0,
      8,
      82,
      0,
      8,
      18,
      85,
      8,
      163,
      83,
      7,
      35,
      0,
      8,
      114,
      0,
      8,
      50,
      0,
      9,
      196,
      81,
      7,
      11,
      0,
      8,
      98,
      0,
      8,
      34,
      0,
      9,
      164,
      0,
      8,
      2,
      0,
      8,
      130,
      0,
      8,
      66,
      0,
      9,
      228,
      80,
      7,
      7,
      0,
      8,
      90,
      0,
      8,
      26,
      0,
      9,
      148,
      84,
      7,
      67,
      0,
      8,
      122,
      0,
      8,
      58,
      0,
      9,
      212,
      82,
      7,
      19,
      0,
      8,
      106,
      0,
      8,
      42,
      0,
      9,
      180,
      0,
      8,
      10,
      0,
      8,
      138,
      0,
      8,
      74,
      0,
      9,
      244,
      80,
      7,
      5,
      0,
      8,
      86,
      0,
      8,
      22,
      192,
      8,
      0,
      83,
      7,
      51,
      0,
      8,
      118,
      0,
      8,
      54,
      0,
      9,
      204,
      81,
      7,
      15,
      0,
      8,
      102,
      0,
      8,
      38,
      0,
      9,
      172,
      0,
      8,
      6,
      0,
      8,
      134,
      0,
      8,
      70,
      0,
      9,
      236,
      80,
      7,
      9,
      0,
      8,
      94,
      0,
      8,
      30,
      0,
      9,
      156,
      84,
      7,
      99,
      0,
      8,
      126,
      0,
      8,
      62,
      0,
      9,
      220,
      82,
      7,
      27,
      0,
      8,
      110,
      0,
      8,
      46,
      0,
      9,
      188,
      0,
      8,
      14,
      0,
      8,
      142,
      0,
      8,
      78,
      0,
      9,
      252,
      96,
      7,
      256,
      0,
      8,
      81,
      0,
      8,
      17,
      85,
      8,
      131,
      82,
      7,
      31,
      0,
      8,
      113,
      0,
      8,
      49,
      0,
      9,
      194,
      80,
      7,
      10,
      0,
      8,
      97,
      0,
      8,
      33,
      0,
      9,
      162,
      0,
      8,
      1,
      0,
      8,
      129,
      0,
      8,
      65,
      0,
      9,
      226,
      80,
      7,
      6,
      0,
      8,
      89,
      0,
      8,
      25,
      0,
      9,
      146,
      83,
      7,
      59,
      0,
      8,
      121,
      0,
      8,
      57,
      0,
      9,
      210,
      81,
      7,
      17,
      0,
      8,
      105,
      0,
      8,
      41,
      0,
      9,
      178,
      0,
      8,
      9,
      0,
      8,
      137,
      0,
      8,
      73,
      0,
      9,
      242,
      80,
      7,
      4,
      0,
      8,
      85,
      0,
      8,
      21,
      80,
      8,
      258,
      83,
      7,
      43,
      0,
      8,
      117,
      0,
      8,
      53,
      0,
      9,
      202,
      81,
      7,
      13,
      0,
      8,
      101,
      0,
      8,
      37,
      0,
      9,
      170,
      0,
      8,
      5,
      0,
      8,
      133,
      0,
      8,
      69,
      0,
      9,
      234,
      80,
      7,
      8,
      0,
      8,
      93,
      0,
      8,
      29,
      0,
      9,
      154,
      84,
      7,
      83,
      0,
      8,
      125,
      0,
      8,
      61,
      0,
      9,
      218,
      82,
      7,
      23,
      0,
      8,
      109,
      0,
      8,
      45,
      0,
      9,
      186,
      0,
      8,
      13,
      0,
      8,
      141,
      0,
      8,
      77,
      0,
      9,
      250,
      80,
      7,
      3,
      0,
      8,
      83,
      0,
      8,
      19,
      85,
      8,
      195,
      83,
      7,
      35,
      0,
      8,
      115,
      0,
      8,
      51,
      0,
      9,
      198,
      81,
      7,
      11,
      0,
      8,
      99,
      0,
      8,
      35,
      0,
      9,
      166,
      0,
      8,
      3,
      0,
      8,
      131,
      0,
      8,
      67,
      0,
      9,
      230,
      80,
      7,
      7,
      0,
      8,
      91,
      0,
      8,
      27,
      0,
      9,
      150,
      84,
      7,
      67,
      0,
      8,
      123,
      0,
      8,
      59,
      0,
      9,
      214,
      82,
      7,
      19,
      0,
      8,
      107,
      0,
      8,
      43,
      0,
      9,
      182,
      0,
      8,
      11,
      0,
      8,
      139,
      0,
      8,
      75,
      0,
      9,
      246,
      80,
      7,
      5,
      0,
      8,
      87,
      0,
      8,
      23,
      192,
      8,
      0,
      83,
      7,
      51,
      0,
      8,
      119,
      0,
      8,
      55,
      0,
      9,
      206,
      81,
      7,
      15,
      0,
      8,
      103,
      0,
      8,
      39,
      0,
      9,
      174,
      0,
      8,
      7,
      0,
      8,
      135,
      0,
      8,
      71,
      0,
      9,
      238,
      80,
      7,
      9,
      0,
      8,
      95,
      0,
      8,
      31,
      0,
      9,
      158,
      84,
      7,
      99,
      0,
      8,
      (int) sbyte.MaxValue,
      0,
      8,
      63,
      0,
      9,
      222,
      82,
      7,
      27,
      0,
      8,
      111,
      0,
      8,
      47,
      0,
      9,
      190,
      0,
      8,
      15,
      0,
      8,
      143,
      0,
      8,
      79,
      0,
      9,
      254,
      96,
      7,
      256,
      0,
      8,
      80,
      0,
      8,
      16,
      84,
      8,
      115,
      82,
      7,
      31,
      0,
      8,
      112,
      0,
      8,
      48,
      0,
      9,
      193,
      80,
      7,
      10,
      0,
      8,
      96,
      0,
      8,
      32,
      0,
      9,
      161,
      0,
      8,
      0,
      0,
      8,
      128,
      0,
      8,
      64,
      0,
      9,
      225,
      80,
      7,
      6,
      0,
      8,
      88,
      0,
      8,
      24,
      0,
      9,
      145,
      83,
      7,
      59,
      0,
      8,
      120,
      0,
      8,
      56,
      0,
      9,
      209,
      81,
      7,
      17,
      0,
      8,
      104,
      0,
      8,
      40,
      0,
      9,
      177,
      0,
      8,
      8,
      0,
      8,
      136,
      0,
      8,
      72,
      0,
      9,
      241,
      80,
      7,
      4,
      0,
      8,
      84,
      0,
      8,
      20,
      85,
      8,
      227,
      83,
      7,
      43,
      0,
      8,
      116,
      0,
      8,
      52,
      0,
      9,
      201,
      81,
      7,
      13,
      0,
      8,
      100,
      0,
      8,
      36,
      0,
      9,
      169,
      0,
      8,
      4,
      0,
      8,
      132,
      0,
      8,
      68,
      0,
      9,
      233,
      80,
      7,
      8,
      0,
      8,
      92,
      0,
      8,
      28,
      0,
      9,
      153,
      84,
      7,
      83,
      0,
      8,
      124,
      0,
      8,
      60,
      0,
      9,
      217,
      82,
      7,
      23,
      0,
      8,
      108,
      0,
      8,
      44,
      0,
      9,
      185,
      0,
      8,
      12,
      0,
      8,
      140,
      0,
      8,
      76,
      0,
      9,
      249,
      80,
      7,
      3,
      0,
      8,
      82,
      0,
      8,
      18,
      85,
      8,
      163,
      83,
      7,
      35,
      0,
      8,
      114,
      0,
      8,
      50,
      0,
      9,
      197,
      81,
      7,
      11,
      0,
      8,
      98,
      0,
      8,
      34,
      0,
      9,
      165,
      0,
      8,
      2,
      0,
      8,
      130,
      0,
      8,
      66,
      0,
      9,
      229,
      80,
      7,
      7,
      0,
      8,
      90,
      0,
      8,
      26,
      0,
      9,
      149,
      84,
      7,
      67,
      0,
      8,
      122,
      0,
      8,
      58,
      0,
      9,
      213,
      82,
      7,
      19,
      0,
      8,
      106,
      0,
      8,
      42,
      0,
      9,
      181,
      0,
      8,
      10,
      0,
      8,
      138,
      0,
      8,
      74,
      0,
      9,
      245,
      80,
      7,
      5,
      0,
      8,
      86,
      0,
      8,
      22,
      192,
      8,
      0,
      83,
      7,
      51,
      0,
      8,
      118,
      0,
      8,
      54,
      0,
      9,
      205,
      81,
      7,
      15,
      0,
      8,
      102,
      0,
      8,
      38,
      0,
      9,
      173,
      0,
      8,
      6,
      0,
      8,
      134,
      0,
      8,
      70,
      0,
      9,
      237,
      80,
      7,
      9,
      0,
      8,
      94,
      0,
      8,
      30,
      0,
      9,
      157,
      84,
      7,
      99,
      0,
      8,
      126,
      0,
      8,
      62,
      0,
      9,
      221,
      82,
      7,
      27,
      0,
      8,
      110,
      0,
      8,
      46,
      0,
      9,
      189,
      0,
      8,
      14,
      0,
      8,
      142,
      0,
      8,
      78,
      0,
      9,
      253,
      96,
      7,
      256,
      0,
      8,
      81,
      0,
      8,
      17,
      85,
      8,
      131,
      82,
      7,
      31,
      0,
      8,
      113,
      0,
      8,
      49,
      0,
      9,
      195,
      80,
      7,
      10,
      0,
      8,
      97,
      0,
      8,
      33,
      0,
      9,
      163,
      0,
      8,
      1,
      0,
      8,
      129,
      0,
      8,
      65,
      0,
      9,
      227,
      80,
      7,
      6,
      0,
      8,
      89,
      0,
      8,
      25,
      0,
      9,
      147,
      83,
      7,
      59,
      0,
      8,
      121,
      0,
      8,
      57,
      0,
      9,
      211,
      81,
      7,
      17,
      0,
      8,
      105,
      0,
      8,
      41,
      0,
      9,
      179,
      0,
      8,
      9,
      0,
      8,
      137,
      0,
      8,
      73,
      0,
      9,
      243,
      80,
      7,
      4,
      0,
      8,
      85,
      0,
      8,
      21,
      80,
      8,
      258,
      83,
      7,
      43,
      0,
      8,
      117,
      0,
      8,
      53,
      0,
      9,
      203,
      81,
      7,
      13,
      0,
      8,
      101,
      0,
      8,
      37,
      0,
      9,
      171,
      0,
      8,
      5,
      0,
      8,
      133,
      0,
      8,
      69,
      0,
      9,
      235,
      80,
      7,
      8,
      0,
      8,
      93,
      0,
      8,
      29,
      0,
      9,
      155,
      84,
      7,
      83,
      0,
      8,
      125,
      0,
      8,
      61,
      0,
      9,
      219,
      82,
      7,
      23,
      0,
      8,
      109,
      0,
      8,
      45,
      0,
      9,
      187,
      0,
      8,
      13,
      0,
      8,
      141,
      0,
      8,
      77,
      0,
      9,
      251,
      80,
      7,
      3,
      0,
      8,
      83,
      0,
      8,
      19,
      85,
      8,
      195,
      83,
      7,
      35,
      0,
      8,
      115,
      0,
      8,
      51,
      0,
      9,
      199,
      81,
      7,
      11,
      0,
      8,
      99,
      0,
      8,
      35,
      0,
      9,
      167,
      0,
      8,
      3,
      0,
      8,
      131,
      0,
      8,
      67,
      0,
      9,
      231,
      80,
      7,
      7,
      0,
      8,
      91,
      0,
      8,
      27,
      0,
      9,
      151,
      84,
      7,
      67,
      0,
      8,
      123,
      0,
      8,
      59,
      0,
      9,
      215,
      82,
      7,
      19,
      0,
      8,
      107,
      0,
      8,
      43,
      0,
      9,
      183,
      0,
      8,
      11,
      0,
      8,
      139,
      0,
      8,
      75,
      0,
      9,
      247,
      80,
      7,
      5,
      0,
      8,
      87,
      0,
      8,
      23,
      192,
      8,
      0,
      83,
      7,
      51,
      0,
      8,
      119,
      0,
      8,
      55,
      0,
      9,
      207,
      81,
      7,
      15,
      0,
      8,
      103,
      0,
      8,
      39,
      0,
      9,
      175,
      0,
      8,
      7,
      0,
      8,
      135,
      0,
      8,
      71,
      0,
      9,
      239,
      80,
      7,
      9,
      0,
      8,
      95,
      0,
      8,
      31,
      0,
      9,
      159,
      84,
      7,
      99,
      0,
      8,
      (int) sbyte.MaxValue,
      0,
      8,
      63,
      0,
      9,
      223,
      82,
      7,
      27,
      0,
      8,
      111,
      0,
      8,
      47,
      0,
      9,
      191,
      0,
      8,
      15,
      0,
      8,
      143,
      0,
      8,
      79,
      0,
      9,
      (int) byte.MaxValue
    };
    internal static readonly int[] fixed_td = new int[96]
    {
      80,
      5,
      1,
      87,
      5,
      257,
      83,
      5,
      17,
      91,
      5,
      4097,
      81,
      5,
      5,
      89,
      5,
      1025,
      85,
      5,
      65,
      93,
      5,
      16385,
      80,
      5,
      3,
      88,
      5,
      513,
      84,
      5,
      33,
      92,
      5,
      8193,
      82,
      5,
      9,
      90,
      5,
      2049,
      86,
      5,
      129,
      192,
      5,
      24577,
      80,
      5,
      2,
      87,
      5,
      385,
      83,
      5,
      25,
      91,
      5,
      6145,
      81,
      5,
      7,
      89,
      5,
      1537,
      85,
      5,
      97,
      93,
      5,
      24577,
      80,
      5,
      4,
      88,
      5,
      769,
      84,
      5,
      49,
      92,
      5,
      12289,
      82,
      5,
      13,
      90,
      5,
      3073,
      86,
      5,
      193,
      192,
      5,
      24577
    };
    internal static readonly int[] cplens = new int[31]
    {
      3,
      4,
      5,
      6,
      7,
      8,
      9,
      10,
      11,
      13,
      15,
      17,
      19,
      23,
      27,
      31,
      35,
      43,
      51,
      59,
      67,
      83,
      99,
      115,
      131,
      163,
      195,
      227,
      258,
      0,
      0
    };
    internal static readonly int[] cplext = new int[31]
    {
      0,
      0,
      0,
      0,
      0,
      0,
      0,
      0,
      1,
      1,
      1,
      1,
      2,
      2,
      2,
      2,
      3,
      3,
      3,
      3,
      4,
      4,
      4,
      4,
      5,
      5,
      5,
      5,
      0,
      112,
      112
    };
    internal static readonly int[] cpdist = new int[30]
    {
      1,
      2,
      3,
      4,
      5,
      7,
      9,
      13,
      17,
      25,
      33,
      49,
      65,
      97,
      129,
      193,
      257,
      385,
      513,
      769,
      1025,
      1537,
      2049,
      3073,
      4097,
      6145,
      8193,
      12289,
      16385,
      24577
    };
    internal static readonly int[] cpdext = new int[30]
    {
      0,
      0,
      0,
      0,
      1,
      1,
      2,
      2,
      3,
      3,
      4,
      4,
      5,
      5,
      6,
      6,
      7,
      7,
      8,
      8,
      9,
      9,
      10,
      10,
      11,
      11,
      12,
      12,
      13,
      13
    };
    internal const int BMAX = 15;
    internal int[] hn = (int[]) null;
    internal int[] v = (int[]) null;
    internal int[] c = (int[]) null;
    internal int[] r = (int[]) null;
    internal int[] u = (int[]) null;
    internal int[] x = (int[]) null;

    private int huft_build(
      int[] b,
      int bindex,
      int n,
      int s,
      int[] d,
      int[] e,
      int[] t,
      int[] m,
      int[] hp,
      int[] hn,
      int[] v)
    {
      int num1 = 0;
      int num2 = n;
      do
      {
        ++this.c[b[bindex + num1]];
        ++num1;
        --num2;
      }
      while ((uint) num2 > 0U);
      if (this.c[0] == n)
      {
        t[0] = -1;
        m[0] = 0;
        return 0;
      }
      int num3 = m[0];
      int index1 = 1;
      while (index1 <= 15 && (uint) this.c[index1] <= 0U)
        ++index1;
      int index2 = index1;
      if (num3 < index1)
        num3 = index1;
      int index3 = 15;
      while ((uint) index3 > 0U && (uint) this.c[index3] <= 0U)
        --index3;
      int index4 = index3;
      if (num3 > index3)
        num3 = index3;
      m[0] = num3;
      int num4 = 1 << index1;
      while (index1 < index3)
      {
        int num5;
        if ((num5 = num4 - this.c[index1]) < 0)
          return -3;
        ++index1;
        num4 = num5 << 1;
      }
      int num6;
      if ((num6 = num4 - this.c[index3]) < 0)
        return -3;
      this.c[index3] += num6;
      int num7;
      this.x[1] = num7 = 0;
      int index5 = 1;
      int index6 = 2;
      while ((uint) --index3 > 0U)
      {
        this.x[index6] = (num7 += this.c[index5]);
        ++index6;
        ++index5;
      }
      int num8 = 0;
      int num9 = 0;
      do
      {
        int index7;
        if ((uint) (index7 = b[bindex + num9]) > 0U)
          v[this.x[index7]++] = num8;
        ++num9;
      }
      while (++num8 < n);
      n = this.x[index4];
      int number1;
      this.x[0] = number1 = 0;
      int index8 = 0;
      int index9 = -1;
      int bits = -num3;
      this.u[0] = 0;
      int num10 = 0;
      int num11 = 0;
      for (; index2 <= index4; ++index2)
      {
        int num12 = this.c[index2];
        while ((uint) num12-- > 0U)
        {
          while (index2 > bits + num3)
          {
            ++index9;
            bits += num3;
            int num13 = index4 - bits;
            int num14 = num13 > num3 ? num3 : num13;
            int num15;
            int num16;
            if ((num16 = 1 << (num15 = index2 - bits)) > num12 + 1)
            {
              int num17 = num16 - (num12 + 1);
              int index10 = index2;
              if (num15 < num14)
              {
                int num18;
                while (++num15 < num14 && (num18 = num17 << 1) > this.c[++index10])
                  num17 = num18 - this.c[index10];
              }
            }
            num11 = 1 << num15;
            if (hn[0] + num11 > 1440)
              return -3;
            this.u[index9] = num10 = hn[0];
            hn[0] += num11;
            if ((uint) index9 > 0U)
            {
              this.x[index9] = number1;
              this.r[0] = (int) (sbyte) num15;
              this.r[1] = (int) (sbyte) num3;
              int num19 = SharedUtils.URShift(number1, bits - num3);
              this.r[2] = num10 - this.u[index9 - 1] - num19;
              Array.Copy((Array) this.r, 0, (Array) hp, (this.u[index9 - 1] + num19) * 3, 3);
            }
            else
              t[0] = num10;
          }
          this.r[1] = (int) (sbyte) (index2 - bits);
          if (index8 >= n)
            this.r[0] = 192;
          else if (v[index8] < s)
          {
            this.r[0] = v[index8] < 256 ? 0 : 96;
            this.r[2] = v[index8++];
          }
          else
          {
            this.r[0] = (int) (sbyte) (e[v[index8] - s] + 16 + 64);
            this.r[2] = d[v[index8++] - s];
          }
          int num20 = 1 << index2 - bits;
          for (int index11 = SharedUtils.URShift(number1, bits); index11 < num11; index11 += num20)
            Array.Copy((Array) this.r, 0, (Array) hp, (num10 + index11) * 3, 3);
          int number2;
          for (number2 = 1 << index2 - 1; (uint) (number1 & number2) > 0U; number2 = SharedUtils.URShift(number2, 1))
            number1 ^= number2;
          number1 ^= number2;
          for (int index12 = (1 << bits) - 1; (number1 & index12) != this.x[index9]; index12 = (1 << bits) - 1)
          {
            --index9;
            bits -= num3;
          }
        }
      }
      return num6 == 0 || index4 == 1 ? 0 : -5;
    }

    internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
    {
      this.initWorkArea(19);
      this.hn[0] = 0;
      int num1 = this.huft_build(c, 0, 19, 19, (int[]) null, (int[]) null, tb, bb, hp, this.hn, this.v);
      int num2;
      switch (num1)
      {
        case -5:
          num2 = 1;
          break;
        case -3:
          z.Message = "oversubscribed dynamic bit lengths tree";
          goto label_6;
        default:
          num2 = bb[0] == 0 ? 1 : 0;
          break;
      }
      if (num2 != 0)
      {
        z.Message = "incomplete dynamic bit lengths tree";
        num1 = -3;
      }
label_6:
      return num1;
    }

    internal int inflate_trees_dynamic(
      int nl,
      int nd,
      int[] c,
      int[] bl,
      int[] bd,
      int[] tl,
      int[] td,
      int[] hp,
      ZlibCodec z)
    {
      this.initWorkArea(288);
      this.hn[0] = 0;
      int num1 = this.huft_build(c, 0, nl, 257, InfTree.cplens, InfTree.cplext, tl, bl, hp, this.hn, this.v);
      if (num1 != 0 || bl[0] == 0)
      {
        switch (num1)
        {
          case -4:
            return num1;
          case -3:
            z.Message = "oversubscribed literal/length tree";
            goto case -4;
          default:
            z.Message = "incomplete literal/length tree";
            num1 = -3;
            goto case -4;
        }
      }
      else
      {
        this.initWorkArea(288);
        int num2 = this.huft_build(c, nl, nd, 0, InfTree.cpdist, InfTree.cpdext, td, bd, hp, this.hn, this.v);
        if (num2 == 0 && (bd[0] != 0 || nl <= 257))
          return 0;
        switch (num2)
        {
          case -5:
            z.Message = "incomplete distance tree";
            num2 = -3;
            goto case -4;
          case -4:
            return num2;
          case -3:
            z.Message = "oversubscribed distance tree";
            goto case -4;
          default:
            z.Message = "empty distance tree with lengths";
            num2 = -3;
            goto case -4;
        }
      }
    }

    internal static int inflate_trees_fixed(
      int[] bl,
      int[] bd,
      int[][] tl,
      int[][] td,
      ZlibCodec z)
    {
      bl[0] = 9;
      bd[0] = 5;
      tl[0] = InfTree.fixed_tl;
      td[0] = InfTree.fixed_td;
      return 0;
    }

    private void initWorkArea(int vsize)
    {
      if (this.hn == null)
      {
        this.hn = new int[1];
        this.v = new int[vsize];
        this.c = new int[16];
        this.r = new int[3];
        this.u = new int[15];
        this.x = new int[16];
      }
      else
      {
        if (this.v.Length < vsize)
          this.v = new int[vsize];
        Array.Clear((Array) this.v, 0, vsize);
        Array.Clear((Array) this.c, 0, 16);
        this.r[0] = 0;
        this.r[1] = 0;
        this.r[2] = 0;
        Array.Clear((Array) this.u, 0, 15);
        Array.Clear((Array) this.x, 0, 16);
      }
    }
  }
}

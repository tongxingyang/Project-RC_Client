﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIGrid_ArrangementWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UIGrid.Arrangement));
		L.RegVar("Horizontal", get_Horizontal, null);
		L.RegVar("Vertical", get_Vertical, null);
		L.RegVar("CellSnap", get_CellSnap, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Horizontal(IntPtr L)
	{
		ToLua.Push(L, UIGrid.Arrangement.Horizontal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Vertical(IntPtr L)
	{
		ToLua.Push(L, UIGrid.Arrangement.Vertical);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CellSnap(IntPtr L)
	{
		ToLua.Push(L, UIGrid.Arrangement.CellSnap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UIGrid.Arrangement o = (UIGrid.Arrangement)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

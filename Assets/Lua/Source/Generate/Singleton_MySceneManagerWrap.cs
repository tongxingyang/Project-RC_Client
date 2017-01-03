﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Singleton_MySceneManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Singleton<MySceneManager>), typeof(System.Object), "Singleton_MySceneManager");
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("New", _CreateSingleton_MySceneManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingleton_MySceneManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Singleton<MySceneManager> obj = new Singleton<MySceneManager>();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Singleton<MySceneManager>.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			MySceneManager o = Singleton<MySceneManager>.GetInstance();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

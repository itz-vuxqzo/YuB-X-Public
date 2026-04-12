#pragma once

#include <thread>
#include <lstate.h>
#include <functional>

struct YieldState
{
    uintptr_t State; // 0x0
    uintptr_t TimeUsed; // 0x8
    uintptr_t Useless; // 0x10
};

struct YieldingLuaThread
{
    char Pad0[0x28];
    lua_State* L; // 0x28
};

using Yielded = std::function<int(lua_State*)>;
namespace Yielding
{
	int YieldExecution(lua_State* L, const std::function<Yielded()>& Function);
	void RunYield();
}
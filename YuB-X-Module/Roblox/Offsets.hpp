#pragma once

#include <cstdint>
#include <Windows.h>

struct lua_State;
struct YieldState;
struct YieldingLuaThread;

#define REBASE(Address) (Address + reinterpret_cast<uintptr_t>(GetModuleHandleA(nullptr)))

namespace Offsets
{
    const uintptr_t Print = REBASE(0x1DEC8F0);
    const uintptr_t OpcodeLookupTable = REBASE(0x5F42790);
    const uintptr_t ScriptContextResume = REBASE(0x1D67A90);
    const uintptr_t GetLuaStateForInstance = REBASE(0x1C95DD0);

    namespace Luau
    {
        const uintptr_t Luau_Execute = REBASE(0x4449200);
        const uintptr_t LuaO_NilObject = REBASE(0x6688740);
        const uintptr_t LuaH_DummyNode = REBASE(0x66885E8);
    }

    namespace DataModel
    {
        const uintptr_t Children = 0x78;
        const uintptr_t GameLoaded = 0x638;
        const uintptr_t ScriptContext = 0x440;
        const uintptr_t FakeDataModelToDataModel = 0x1D0;

        const uintptr_t FakeDataModelPointer = REBASE(0x78FF228);
    }

    namespace ExtraSpace
    {
        const uintptr_t RequireBypass = 0x9E1;
        const uintptr_t ScriptContextToResume = 0x7F8;
    }
}

namespace Roblox
{
    inline auto Print = (uintptr_t(*)(int, const char*, ...))Offsets::Print;
    inline auto Luau_Execute = (void(__fastcall*)(lua_State*))Offsets::Luau::Luau_Execute;
    inline auto GetLuaStateForInstance = (lua_State*(__fastcall*)(uint64_t, uint64_t*, uint64_t*))Offsets::GetLuaStateForInstance;
    inline auto ScriptContextResume = (uint64_t(__fastcall*)(uint64_t, YieldState*, YieldingLuaThread**, uint32_t, uint8_t, uint64_t))Offsets::ScriptContextResume;
}

// Dont forget to update Encryptions and Structs
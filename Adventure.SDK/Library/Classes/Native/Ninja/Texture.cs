using Ninja.SDK.Library.Structures.Graphics;
using Reloaded.Hooks.Definitions.X86;
using Reloaded.Hooks.X64;
using System.Runtime.InteropServices;

namespace Adventure.SDK.Library.Classes.Native.Ninja
{
    public struct Texture
    {
        // Variables/Constants
        public static LoadTextureFile LoadTexture = Wrapper.Create<LoadTextureFile>(0x77FC80);
        public static ReleaseTexture ReleaseTextureList = Wrapper.Create<ReleaseTexture>(0x403290);

        // Delegates
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate int ReleaseTexture(TextureList* textureList);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [Function(CallingConventions.Cdecl)]
        public unsafe delegate int LoadTextureFile(string fileName, TextureList* textureList);
    }
}
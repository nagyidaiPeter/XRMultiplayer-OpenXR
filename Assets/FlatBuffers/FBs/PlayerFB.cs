// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace hololensMulti
{

using global::System;
using global::FlatBuffers;

public struct TransformFB : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static TransformFB GetRootAsTransformFB(ByteBuffer _bb) { return GetRootAsTransformFB(_bb, new TransformFB()); }
  public static TransformFB GetRootAsTransformFB(ByteBuffer _bb, TransformFB obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TransformFB __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int PlayerID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public hololensMulti.Vec3? Pos { get { int o = __p.__offset(6); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Vec3? QrOffset { get { int o = __p.__offset(8); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Quat? Rot { get { int o = __p.__offset(10); return o != 0 ? (hololensMulti.Quat?)(new hololensMulti.Quat()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public bool RHActive { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public hololensMulti.HandState? RHState { get { int o = __p.__offset(14); return o != 0 ? (hololensMulti.HandState?)(new hololensMulti.HandState()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Vec3? RHPos { get { int o = __p.__offset(16); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Quat? RHRot { get { int o = __p.__offset(18); return o != 0 ? (hololensMulti.Quat?)(new hololensMulti.Quat()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public bool LHActive { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public hololensMulti.HandState? LHState { get { int o = __p.__offset(22); return o != 0 ? (hololensMulti.HandState?)(new hololensMulti.HandState()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Vec3? LHPos { get { int o = __p.__offset(24); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Quat? LHRot { get { int o = __p.__offset(26); return o != 0 ? (hololensMulti.Quat?)(new hololensMulti.Quat()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public hololensMulti.Vec3? PointerPos { get { int o = __p.__offset(28); return o != 0 ? (hololensMulti.Vec3?)(new hololensMulti.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartTransformFB(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddPlayerID(FlatBufferBuilder builder, int PlayerID) { builder.AddInt(0, PlayerID, 0); }
  public static void AddPos(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> PosOffset) { builder.AddStruct(1, PosOffset.Value, 0); }
  public static void AddQrOffset(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> QrOffsetOffset) { builder.AddStruct(2, QrOffsetOffset.Value, 0); }
  public static void AddRot(FlatBufferBuilder builder, Offset<hololensMulti.Quat> RotOffset) { builder.AddStruct(3, RotOffset.Value, 0); }
  public static void AddRHActive(FlatBufferBuilder builder, bool RHActive) { builder.AddBool(4, RHActive, false); }
  public static void AddRHState(FlatBufferBuilder builder, Offset<hololensMulti.HandState> RHStateOffset) { builder.AddStruct(5, RHStateOffset.Value, 0); }
  public static void AddRHPos(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> RHPosOffset) { builder.AddStruct(6, RHPosOffset.Value, 0); }
  public static void AddRHRot(FlatBufferBuilder builder, Offset<hololensMulti.Quat> RHRotOffset) { builder.AddStruct(7, RHRotOffset.Value, 0); }
  public static void AddLHActive(FlatBufferBuilder builder, bool LHActive) { builder.AddBool(8, LHActive, false); }
  public static void AddLHState(FlatBufferBuilder builder, Offset<hololensMulti.HandState> LHStateOffset) { builder.AddStruct(9, LHStateOffset.Value, 0); }
  public static void AddLHPos(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> LHPosOffset) { builder.AddStruct(10, LHPosOffset.Value, 0); }
  public static void AddLHRot(FlatBufferBuilder builder, Offset<hololensMulti.Quat> LHRotOffset) { builder.AddStruct(11, LHRotOffset.Value, 0); }
  public static void AddPointerPos(FlatBufferBuilder builder, Offset<hololensMulti.Vec3> PointerPosOffset) { builder.AddStruct(12, PointerPosOffset.Value, 0); }
  public static Offset<hololensMulti.TransformFB> EndTransformFB(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<hololensMulti.TransformFB>(o);
  }
  public static void FinishTransformFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.TransformFB> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTransformFBBuffer(FlatBufferBuilder builder, Offset<hololensMulti.TransformFB> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}

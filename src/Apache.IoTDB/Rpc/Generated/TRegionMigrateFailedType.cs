/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

public enum TRegionMigrateFailedType
{
  AddPeerFailed = 0,
  RemovePeerFailed = 1,
  RemoveConsensusGroupFailed = 2,
  DeleteRegionFailed = 3,
  CreateRegionFailed = 4,
  Disconnect = 5,
}

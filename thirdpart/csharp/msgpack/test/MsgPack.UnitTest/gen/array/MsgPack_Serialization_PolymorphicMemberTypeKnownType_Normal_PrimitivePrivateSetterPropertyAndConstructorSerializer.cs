﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor).GetMethod("set_Primitive", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(int)}, null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor objectTree) {
            packer.PackArrayHeader(1);
            this._serializer0.PackTo(packer, objectTree.Primitive);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Nullable<int> nullable = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor), "Int32 Primitive");
                }
                if (nullable.HasValue) {
                    this._methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0.Invoke(result, new object[] {
                                ((object)(nullable.Value))});
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Primitive")) {
                        System.Nullable<int> nullable1 = default(System.Nullable<int>);
                        nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor), "Int32 Primitive");
                        if (nullable1.HasValue) {
                            this._methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0.Invoke(result, new object[] {
                                        ((object)(nullable1.Value))});
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}

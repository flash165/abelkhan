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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject objectTree) {
            packer.PackArrayHeader(1);
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject);
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                object ctorArg0 = default(object);
                ctorArg0 = null;
                object nullable = default(object);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer0.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer0.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    ctorArg0 = nullable;
                }
                unpacked = (unpacked + 1);
                result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject(ctorArg0);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                object ctorArg00 = default(object);
                ctorArg00 = null;
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Value")) {
                        object nullable1 = default(object);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer0.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer0.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable1 == null) 
                                    == false)) {
                            ctorArg00 = nullable1;
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
                result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_ValueReadOnlyFieldAndConstructorAsObject(ctorArg00);
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

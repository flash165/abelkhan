﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PlainClassSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PlainClass> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer2;
        
        public MsgPack_Serialization_PlainClassSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.List<int>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<int>(schema2);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            packer.PackMapHeader(3);
            this._serializer0.PackTo(packer, "CollectionReadOnlyProperty");
            this._serializer1.PackTo(packer, objectTree.CollectionReadOnlyProperty);
            this._serializer0.PackTo(packer, "PublicField");
            this._serializer2.PackTo(packer, objectTree.PublicField);
            this._serializer0.PackTo(packer, "PublicProperty");
            this._serializer2.PackTo(packer, objectTree.PublicProperty);
        }
        
        protected internal override MsgPack.Serialization.PlainClass UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PlainClass result = default(MsgPack.Serialization.PlainClass);
            result = new MsgPack.Serialization.PlainClass();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Collections.Generic.List<int> nullable = default(System.Collections.Generic.List<int>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
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
                    System.Collections.Generic.List<int>.Enumerator enumerator = nullable.GetEnumerator();
                    int current;
                    try {
                        for (
                        ; enumerator.MoveNext(); 
                        ) {
                            current = enumerator.Current;
                            result.CollectionReadOnlyProperty.Add(current);
                        }
                    }
                    finally {
                        enumerator.Dispose();
                    }
                }
                unpacked = (unpacked + 1);
                System.Nullable<int> nullable0 = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "Int32 PublicField");
                }
                if (nullable0.HasValue) {
                    result.PublicField = nullable0.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<int> nullable1 = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "Int32 PublicProperty");
                }
                if (nullable1.HasValue) {
                    result.PublicProperty = nullable1.Value;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable2 = default(string);
                    nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PlainClass), "MemberName");
                    if (((nullable2 == null) 
                                == false)) {
                        key = nullable2;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "PublicProperty")) {
                        System.Nullable<int> nullable5 = default(System.Nullable<int>);
                        nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "Int32 PublicProperty");
                        if (nullable5.HasValue) {
                            result.PublicProperty = nullable5.Value;
                        }
                    }
                    else {
                        if ((key == "PublicField")) {
                            System.Nullable<int> nullable4 = default(System.Nullable<int>);
                            nullable4 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "Int32 PublicField");
                            if (nullable4.HasValue) {
                                result.PublicField = nullable4.Value;
                            }
                        }
                        else {
                            if ((key == "CollectionReadOnlyProperty")) {
                                System.Collections.Generic.List<int> nullable3 = default(System.Collections.Generic.List<int>);
                                if ((unpacker.Read() == false)) {
                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                }
                                if (((unpacker.IsArrayHeader == false) 
                                            && (unpacker.IsMapHeader == false))) {
                                    nullable3 = this._serializer1.UnpackFrom(unpacker);
                                }
                                else {
                                    MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                                    disposable0 = unpacker.ReadSubtree();
                                    try {
                                        nullable3 = this._serializer1.UnpackFrom(disposable0);
                                    }
                                    finally {
                                        if (((disposable0 == null) 
                                                    == false)) {
                                            disposable0.Dispose();
                                        }
                                    }
                                }
                                if (((nullable3 == null) 
                                            == false)) {
                                    System.Collections.Generic.List<int>.Enumerator enumerator0 = nullable3.GetEnumerator();
                                    int current0;
                                    try {
                                        for (
                                        ; enumerator0.MoveNext(); 
                                        ) {
                                            current0 = enumerator0.Current;
                                            result.CollectionReadOnlyProperty.Add(current0);
                                        }
                                    }
                                    finally {
                                        enumerator0.Dispose();
                                    }
                                }
                            }
                            else {
                                unpacker.Skip();
                            }
                        }
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

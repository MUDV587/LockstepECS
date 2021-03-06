
//------------------------------------------------------------------------------    
// <auto-generated>                                                                 
//     This code was generated by Tools.MacroExpansion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null. 
//     https://github.com/JiepengTan/LockstepEngine                                          
//     Changes to this file may cause incorrect behavior and will be lost if        
//     the code is regenerated.                                                     
// </auto-generated>                                                                
//------------------------------------------------------------------------------  

//Power by ME //src: https://github.com/JiepengTan/ME  

//#define DONT_USE_GENERATE_CODE                                                                 
                                                                                                 
using System.Linq;                                                                               
using Lockstep.Serialization;                                                                    
using System.Runtime.InteropServices;                                                            
using System.Runtime.CompilerServices;                                                            
using System;                                                                                    
using Lockstep.InternalUnsafeECS;                                                               
using System.Collections;                                                                        
using Lockstep.Math;                                                                             
using System.Collections.Generic;                                                                
using Lockstep.Logging;                                                                          
using Lockstep.Util;                                                                          
namespace Lockstep.UnsafeECS.Game {  
    public unsafe partial struct PlayerCube :IEntity {
        public bool HasComponent(EComponentType compType){
            return EntityUtil._PlayerCubeComponentSet[(int)compType];
        }
    } 

    public static unsafe partial class EntityUtil {
        public static Animator* GetAnimator(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.Animator)){
                return null;
            }
            switch (ptr->_ref._type) {
   
            }
            return null;
        }
        public static CollisionAgent* GetCollisionAgent(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.CollisionAgent)){
                return null;
            }
            switch (ptr->_ref._type) {
   
            }
            return null;
        }
        public static NavMeshAgent* GetNavMeshAgent(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.NavMeshAgent)){
                return null;
            }
            switch (ptr->_ref._type) {
   
            }
            return null;
        }
        public static Prefab* GetPrefab(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.Prefab)){
                return null;
            }
            switch (ptr->_ref._type) {
                case EntityIds.PlayerCube: return &(((PlayerCube* )(ptr))->Prefab);   
            }
            return null;
        }
        public static Transform2D* GetTransform2D(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.Transform2D)){
                return null;
            }
            switch (ptr->_ref._type) {
   
            }
            return null;
        }
        public static Transform3D* GetTransform3D(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.Transform3D)){
                return null;
            }
            switch (ptr->_ref._type) {
                case EntityIds.PlayerCube: return &(((PlayerCube* )(ptr))->Transform);   
            }
            return null;
        }
        public static PlayerCubeTag* GetPlayerCubeTag(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.PlayerCubeTag)){
                return null;
            }
            switch (ptr->_ref._type) {
                case EntityIds.PlayerCube: return &(((PlayerCube* )(ptr))->Tag);   
            }
            return null;
        }
        public static AssetData* GetAssetData(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.AssetData)){
                return null;
            }
            switch (ptr->_ref._type) {
   
            }
            return null;
        }
        public static PlayerData* GetPlayerData(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.PlayerData)){
                return null;
            }
            switch (ptr->_ref._type) {
                case EntityIds.PlayerCube: return &(((PlayerCube* )(ptr))->Player);   
            }
            return null;
        }
        public static MoveData* GetMoveData(Entity* ptr){
            if(!HasComponent(ptr,EComponentType.MoveData)){
                return null;
            }
            switch (ptr->_ref._type) {
                case EntityIds.PlayerCube: return &(((PlayerCube* )(ptr))->Move);   
            }
            return null;
        } 


        public static bool HasComponent(Entity* ptr, EComponentType compType){
            var set = _allComponentSet[ptr->_ref._type];
            if(set != null){
                return set[(int)compType];
            }
            return false;
        }

        public static bool[] _PlayerCubeComponentSet = new bool[]{ 
                false,//None
                false,//Animator
                false,//CollisionAgent
                false,//NavMeshAgent
                true,//Prefab
                false,//Transform2D
                true,//Transform3D
                true,//PlayerCubeTag
                false,//AssetData
                true,//PlayerData
                true,//MoveData
                false
        };  
        
        private static bool[][] _allComponentSet = new bool[][]{
            null,
            EntityUtil._PlayerCubeComponentSet,  
            null,
        };
    }
}
                                                                                
                                                                                         
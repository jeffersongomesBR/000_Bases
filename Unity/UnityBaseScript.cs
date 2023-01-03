using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// --- !THIS IS THE BASE SCRIPT FOR ALL UNITY SCRIPTS! --- ///
//Author: JeffG (as dcoder)

namespace name {

    public class UnityBaseScript : MonoBehaviour {

        #region Class Variables

        //Store instance of other objects
        #region Instances

        //Public Ex.:
        [Header("Script Instances")]
        [Tooltip("This obj will be instantiated at runtime")]
        public GameObject publicInstance;

        //Private Ex.:
        GameObject privateInstance = new GameObject();

        #endregion
        
        //Store references to other's script objects
        #region References

        //Public Ex.:
        [Header("Script References")]
        [Tooltip("Public reference")]
        public GameObject referenceObj;

        //Private Ex.:
        GameObject privateReferenceObj;

        #endregion

        //Store values with special get/set's functions
        #region Properties

        //Public Ex.:
        public string PublicProperty { get; set; }

        //Private Ex.:
        public string PrivateProperty { get; private set; }

        #endregion

        //Store adjustable values that will be used by class members
        #region Parameters

        //Public Ex.:
        [Header("Script Settings")]
        [Tooltip("Public Parameter")]
        public bool adjBoolean = false;

        //Private Ex.:
        int adjInt = 32;

        #endregion

        #endregion

        #region Inheritance Callbacks

        //Awake is called when the script instance is being loaded.
        private void Awake() {
            
            //...
        }

        //Start is called on the frame when a script is enabled
        //just before any of the Update methods are called the first time.
        private void Start() {

            //...
        }

        //This function is called when the object becomes enabled and active.
        private void OnEnable() {
            
            //...
        }

        //This function is called when the behaviour becomes disabled.
        private void OnDisable() {
            
            //...
        }

        //Destroying the attached Behaviour will result in the game or Scene
        //receiving OnDestroy.
        private void OnDestroy() {
            
            //...
        }

        //Update is called every frame, if the MonoBehaviour is enabled.
        private void Update() {

            //...
        }

        //Frame-rate independent MonoBehaviour
        //FixedUpdate message for physics calculations.
        private void FixedUpdate() {
            
            //...
        }

        //LateUpdate is called every frame, if the Behaviour is enabled.
        private void LateUpdate() {
            
            //...
        }

        #endregion

        //A set of instructions that perform a task (tools)
        #region Functions

        //...

        #endregion

        //A set of instructions that are associated with an object (behaviours)
        #region Methods

        //...

        #endregion

    }
}

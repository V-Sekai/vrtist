﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRtist
{
    public class CommandAddGameObject : ICommand
    {
        GameObject gObject = null;
        Transform parent = null;
        Vector3 position;
        Quaternion rotation;
        Vector3 scale;

        public CommandAddGameObject(GameObject o)
        {
            gObject = o;
            parent = o.transform.parent;
        }
        private GameObject GetOrCreateTrash()
        {
            string trashName = "__Trash__";
            GameObject trash = GameObject.Find(trashName);
            if (!trash)
            {
                trash = new GameObject();
                trash.name = trashName;
            }
            return trash;
        }

        public override void Undo()
        {
            gObject.SetActive(false);
            gObject.transform.parent = GetOrCreateTrash().transform;
        }
        public override void Redo()
        {
            gObject.transform.parent = parent;
            gObject.transform.localPosition = position;
            gObject.transform.localRotation = rotation;
            gObject.transform.localScale = scale;
            gObject.SetActive(true);
        }
        public override void Submit()
        {
            position = gObject.transform.localPosition;
            rotation = gObject.transform.localRotation;
            scale = gObject.transform.localScale;
            CommandManager.AddCommand(this);
        }

    }
}

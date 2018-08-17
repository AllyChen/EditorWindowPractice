using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(SpaceWithImageAttribute))]
public class SpaceWithImageAttributeDrawer : DecoratorDrawer {

    Texture2D image;
    SpaceWithImageAttribute _attributeWithImage;

    public override void OnGUI(Rect position)
    {
        if (image == null)
            image = Resources.Load<Texture2D>("logo");

        _attributeWithImage = (SpaceWithImageAttribute)attribute;

        GUI.DrawTexture(position, image);

    }

    public override float GetHeight()
    {
        //Debug.Log(_attributeWithImage.height);
        return base.GetHeight();// + _attributeWithImage.height;
    }

}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Static class for loading
/// different scenes.
/// </summary>
public static class LevelLoader                                                
{
    /// <summary>
    /// Enum for different scenes to load.
    /// </summary>
    public enum SceneEnum
    {
        Main_Menu, Level_1, Victory_Screen, Failure_Screen, Options_Menu
    }
    
    /// <summary>
    /// Loads a scene based on the
    /// given SceneEnum.
    /// </summary>
    /// <param name="scene">
    /// SceneEnum representing the scene to load.
    /// </param>
    public static void Load(SceneEnum scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}

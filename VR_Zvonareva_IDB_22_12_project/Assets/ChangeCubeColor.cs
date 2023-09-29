using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private Renderer cubeRenderer;  // Ссылка на компонент Renderer куба 

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();  // Получаем компонент Renderer куба 
        cubeRenderer.material.color = Color.red;  // Устанавливаем цвет куба на красный 
    }
}

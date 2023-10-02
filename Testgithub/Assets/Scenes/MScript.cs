using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MScript : MonoBehaviour
{
  [SerializeField] private Vector3 movementVector = new Vector3(2f, 0f, 0f); // Задайте вектор переміщення

  void Start()
  {
    // Перемістити об'єкт на вказаний вектор
    transform.Translate(movementVector);
  }
}

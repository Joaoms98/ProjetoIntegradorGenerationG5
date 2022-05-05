﻿using System.ComponentModel.DataAnnotations;

/// <summary>
/// <para>Resume: Mirror class to create a new order </para>
/// <para>By: Lethicya Lopes and Matheus Rodrigues</para>
/// <para>v 1.0</para>
/// <para>Date: 05/05/2022</para>
/// </summary>


namespace IntegratorProject.src.dtos
{
    public class NewOrderDTO
    {
        [Required, StringLength(100)]
        public string Description { get; set; }
        public NewOrderDTO(string description)
        {
            Description = description;
        }
    }

    /// <summary>
    /// <para>Resume: Mirror class to update a order </para>
    /// <para>By: Lethicya Lopes and Matheus Rodrigues</para>
    /// <para>v 1.0</para>
    /// <para>Date: 05/05/2022</para>
    /// </summary>

    public class UpdateOrderDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Description { get; set; }
        public UpdateOrderDTO(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
SELECT Pet.Name, PetType.PetTypeName FROM PetType
JOIN Pet on Pet.TypeId = PetType.Id
WHERE PetType.PetTypeName LIKE 'dog'
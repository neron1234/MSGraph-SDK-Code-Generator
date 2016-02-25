﻿using System;
namespace Vipr.T4TemplateWriter.TemplateProcessor
{
  public enum SubProcessor
    {
      EntityType,
      ComplexType,
      EnumType,
      MediaEntityType,
      Property,
      StreamProperty,
      MediaEntity,
      EntityContainer,
      CollectionProperty,
      NavigationCollectionProperty,
      CollectionReferenceProperty,
      CollectionNotReferenceProperty,
      EntityReferenceType,
      Method,
      NonCollectionMethod,
      CollectionMethod,
      MethodWithBody,
      Other
    }
}

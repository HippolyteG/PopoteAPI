# 📦 Popost API - Documentation

Bienvenue sur la documentation de l'API Popost, votre interface programmable pour interagir avec les données de livraison de colis. Cette API est conçue pour être utilisée avec l'application Popost, permettant une gestion efficace et une notification des livraisons de colis.

## 🌐 API Endpoint

L'API Popost est accessible à l'adresse suivante : `popoteapi.azurewebsites.net`.

## 📚 Modèle de Données

L'API gère un modèle de données simple `box` qui représente une boîte aux lettres ou un colis, avec les attributs suivants :

- `date` : La date et l'heure de la livraison du colis.
- `weight` : Le poids du colis en grammes.

## 🛠️ Technologie

L'API est développée avec ASP.NET Core Web App en .NET 8, offrant une plateforme robuste et performante pour les applications web. Elle est connectée à une base de données Azure DB pour le stockage et la gestion des données.

## 🔐 Authentification

L'API utilise un système d'authentification pour sécuriser l'accès aux données. Les utilisateurs doivent fournir un token valide pour accéder aux endpoints de l'API. Veuillez contacter l'administrateur à admin@popost.com pour obtenir vos clés d'API. -- en cours de production

## 📋 Endpoints

### Récupérer les informations d'une boîte

- GET

  ```
  /
  ```

  - Récupère la liste de toutes les boîtes avec leur date et poids.
  - **Requête :** Aucun paramètre requis.
  - **Réponse :** Liste des `box` avec `date` et `weight`.

### Ajouter une nouvelle boîte

- POST

  ```
  /
  ```

  - Ajoute une nouvelle boîte avec des informations spécifiques.
  - **Corps de la requête :** JSON représentant une `box`.

  ```
  jsonCopy code{
    "date": "2023-01-01T12:00:00",
    "weight": 1200
  }
  ```

  - **Réponse :** Détails de la `box` ajoutée.

## 📦 Utilisation

Pour interagir avec l'API, vous pouvez utiliser des outils comme Postman ou écrire des requêtes directement depuis votre application en utilisant des bibliothèques HTTP comme HttpClient en .NET.

## 📝 Licence

L'API Popost est protégée par des droits d'auteur et destinée à un usage exclusif avec l'application Popost. Pour plus d'informations sur la licence ou les permissions d'utilisation, veuillez nous contacter.
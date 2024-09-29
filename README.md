# Movie Database API

## Overview
This is a simple Movie Database API built with ASP.NET Core. The API supports multiple versions and allows users to manage a collection of movies.

## API Endpoints

### Version 1
- **MoviesV1Controller**:
  - **Get All Movies**: `GET /v1/movies`
  - **Add a Movie**: `POST /v1/movies/add/{title}`
  - **Delete a Movie**: `DELETE /v1/movies/delete/{title}`

### Version 2
- **MoviesV2Controller**:
  - Handles version 2 of the API.
  - Provides functionality to retrieve all movies with some details.
  - Allows adding and deleting movies.
- **Example Endpoints**:
  - Get all movies: `GET https://localhost:7173/v2/movies`
  - Add a movie: `POST https://localhost:7173/v2/movies/add/Inception`
  - Delete a movie: `DELETE https://localhost:7173/v2/movies/delete/Inception`

### Version 3
- **MoviesV3Controller**:
  - Handles version 3 of the API.
  - Provides functionality to get detailed information about a specific movie by title.
  - Allows adding and deleting movies as well.
- **Example Endpoints**:
  - Get movie details: `GET https://localhost:7173/v3/movies/The%20Matrix`
  - Add a movie: `POST https://localhost:7173/v3/movies/add/Inception`
  - Delete a movie: `DELETE https://localhost:7173/v3/movies/delete/Inception`

## Functions and Commands

### 1. Get All Movies
- **Function**: Retrieves a list of all movies in the database.
- **Command**:
  ```bash
  curl -v -k -X GET https://localhost:7173/v1/movies

### 2. Add A Movie 
- **Function**: Adds a new movie to the database
- **Command**:
  '''bash
  curl -v -k -X POST https://localhost:7173/v1/movies/add/Inception

### 3. Delete A Movie
- **Funtion**: Deletes a movie from the database
- **Command**:
  curl -v -k -X DELETE https://localhost:7173/v1/movies/delete/Inception


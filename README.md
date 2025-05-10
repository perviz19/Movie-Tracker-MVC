# Movie-Tracker-MVC

## Project Overview:
Movie Tracker is a platform where users can create accounts, track upcoming or newly released movies, and add them to their watchlist (without watching them). Users can also update their personal settings and search for movies. All of these actions will be handled through an API.

1. User Accounts and Management
AuthController: Handles user account creation, login, and logout processes.

User: Stores user data, such as username, email, and password. User-specific settings and history are stored here.

UserSettings: Stores and manages user preferences, such as notification settings and other customizations.

2. Movie Tracking and Search
MovieController: Fetches data from the API for upcoming and newly released movies. Users can view movie details.

MovieSearch: Allows users to search for movies via the API. Users can search based on title, genre, or other movie attributes.

3. Watchlist Management
WatchlistController: Manages the user’s watchlist. Users can add or remove movies from their list, which they intend to watch later.

UserWatchlist: The model representing movies that a user has added to their watchlist.

4. User Settings
SettingsController: Allows users to update their account settings, such as preferences and notification settings.

UserSettings: Holds and updates the user’s customized settings.

5. Interaction with API
API Integration: All movie-related actions, including fetching movie data, performing searches, and updating watchlists, are handled via an external API.

Movie Data: Movie information such as title, description, release date, genre, and other details are fetched from the API.

Search Functionality: The movie search functionality is integrated with the API, allowing users to search for movies and get relevant results.
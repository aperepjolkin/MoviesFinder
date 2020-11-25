import React, {Component, useEffect} from 'react'
import Navigation from './Nav'
import SearchArea from './SearchArea'
import Movie from './Movie'
import Container from 'react-bootstrap/Container'
import Row  from 'react-bootstrap/Row'
import MovieList from './MovieList'

class App extends Component {
	
	constructor() {
		super()

		this.state = {
			findMovieByTitle: '',
			movies: [],
			searchTerm: '',
			showResult: false,
			movieOverview: null
		}
		this.apiKey = process.env.REACT_APP_API
		
	}

	handleSubmit = (e) => {
		e.preventDefault();

		(async () => {
			const rawResponse = await fetch('https://localhost:44308/Movies', {
			  method: 'POST',
			  headers: {
				'Accept': 'application/json',
				'Content-Type': 'application/json'
			  },
			  body: JSON.stringify({"Title": this.state.searchTerm})
			})
			.then(data => data.json())
			.then(data => {
				this.setState({
					findMovieByTitle: JSON.parse(data)
				})
			});

			if(this.state.findMovieByTitle.Title !== null){ 
				this.setState({
					showResult: true
				})
				
			}

		  })();
	}
	componentDidMount() {
		this.showSearchedMoviesList();
	  }

	showSearchedMoviesList = () => {
		(async () => {
			const rawResponse = await fetch('https://localhost:44308/Movies', {
			  method: 'GET',
			  headers: {
				'Accept': 'application/json',
				'Content-Type': 'application/json'
			  }
			})
			.then(data => data.json())
			.then(data => {
				this.setState({
					movies: [...JSON.parse(data)]
				})
			});
		  })();
	}
	handleChange = (e) => {
		this.setState({ searchTerm: e.target.value })
	}

	viewMovieInfo = (id) => {
		const filteredMovie = this.state.movies.filter(movie => movie.id = id)

		const currentMovie = filteredMovie.length > 0 ? filteredMovie[0] : null

		this.searchTerm({ currentMovie: filteredMovie})
	}

	closeMovieView = () => {
		this.setState({ currentMovie: null})
	}
	render() {
		const { showResult } = this.state;
		return (
			<div className="App"> 
			<Container>
				<Navigation />
				<Row>
						<SearchArea handleSubmit={this.handleSubmit} handleChange={this.handleChange}/>
				</Row>
				{  showResult && (
					<Movie key="1" movie={this.state.findMovieByTitle} />
				)}
                 <MovieList movies={this.state.movies} />
					
		    </Container>
			</div>
			);
		}
	}
  

export default App;

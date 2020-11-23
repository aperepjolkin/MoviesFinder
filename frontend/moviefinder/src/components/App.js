import React, {Component} from 'react'
import Navigation from './Nav'
import SearchArea from './SearchArea'

class App extends Component {
	
	constructor() {
		super()

		this.state = {
			movies: [],
			searchTerm: ''
		}
		this.apiKey = process.env.REACT_APP_API
	}

	handleSubmit = (e) => {
		e.preventDefault();

		fetch(`http://www.omdbapi.com/?apikey=7878efa8&t=${this.state.searchTerm}`)
		.then(data => data.json())
		.then(data => {
			console.log(data);
			this.setState({
				movies: data.results
			})
		})
	}

	handleChange = (e) => {
		console.log(e.target.value)
		this.setState({ searchTerm: e.target.value })
	}
	render() {
		return (
			<div className="App"> 
			<Navigation />
			<SearchArea handleSubmit={this.handleSubmit} handleChange={this.handleChange}/>
			</div>
			);
		}
	}
  

export default App;

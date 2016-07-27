
var LibraryChallengeResults = React.createClass({
    getInitialState: function() {
        return {message: 'library challenge task 1 ready'};
    },
    componentWillMount: function() {
        
    },
    componentDidMount: function() {
        
    },
    componentWillReceiveProps: function(nextProps) {
        
    },
    shouldComponentUpdate: function(nextProps, nextState) {
        return true;
    },
    componentWillUpdate: function(nextProps, nextState) {
        
    },
    componentDidUpdate: function(prevProps, prevState) {
        
    },
    componentWillUnmount: function() {
        
    },
    render: function() {
        return (
          <div class="library-challenge-results">
            Results will appear here.
            <p>{this.state.message}</p>
          </div>
      );
    }
});

React.render(
    <LibraryChallengeResults />,
    document.getElementById('libraryApplication')
);

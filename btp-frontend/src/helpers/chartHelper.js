class ChartHelper {
    project = null;
    openTickets = null;
    closedTickets = null;

    setProject(project) {
        // to prevent each method having the same project parameter, 
        // this method works like a constructor
        this.project = project;
    }

    getOpenTickets() {
        // retrieves the count of open tickets
        // to prevent multiple loops over project tickets, store the
        // count of open tickest in a variable
        if (this.openTickets) {
            return this.openTickets;
        }

        // Calculate the number of open tickets & save as variable
        return 0;
    }

    getClosedTickets() {
        // retrieves the count of closed tickets
        // to prevent multiple loops over project tickets, store the
        // count of closed tickest in a variable
        if (this.closedTickets) {
            return this.closedTickets;
        }

        // calculate the number of closed tickets & save as variable
        return 0;
    }

    generateTicketStatusGraph() {
        // generates the configuration object used for the open/closed ticket count graph
        return [];
    }

    generateUserContributionGraph() {
        // generates the configuration object used for the number of users who
        // have contributed to either creating/closing tickets
        return [];
    }

    generateTicketLabelGraph() {
        // generates the configuration object for the total number of labels
        // attached to each ticket. E.g. 10 tickets with a bug label = 1 label 'bug' on 
        // graph with a count of 10
        return [];
    }

    generateUsersGraph() {
        // generates the configuration object for the total number of users
        // and a number for how many tickets they have closed
        return [];
    }

    createFakeData() {
        var sampleData = {
            ticketStatusConfig: {
                labels: ['Closed', 'Open'],
                datasets: [{
                    backgroundColor: ['#f8f9fa', '#198754'],
                    data: [4, 10]
                }]
            },
            ticketConfig: {
                labels: ['Bug', 'Documentation', 'Help Wanted', 'Invalid'],
                datasets: [{
                    backgroundColor: ['red', 'blue', 'green', 'yellow', ],
                    data: [4, 2, 3, 5]
                }]
            },
            usersWhoHaveContributedConfig: {
                labels: ['No contributions', 'Contributed'],
                datasets: [{
                    backgroundColor: ['#f8f9fa', '#198754'],
                    data: [1, 10]
                }]
            },
            ticketsClosedPerUserConfig: {
                labels: ['hbux', 'jdoe', 'msmith'],
                datasets: [{
                    backgroundColor: '#ff6a3d',
                    data: [4, 6, 1]
                }]
            },
            chartOptions: {
                responsive: true,
                plugins: {
                    legend: {
                        display: false
                    }
                }
            }
        }

        return sampleData;
    }
}

export default new ChartHelper();
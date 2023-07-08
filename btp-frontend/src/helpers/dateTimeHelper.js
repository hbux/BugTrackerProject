class DateTimeProvider {
    calculateTimeAgo(dateTime) {
        // calculates an average amount of time that has elapsed
        if (!dateTime) {
            return '';
        }

        const now = new Date();
        const created = new Date(dateTime);
        const diff = Math.abs(now - created);

        if (created.getFullYear() == 1) {
            // optional dateTime objects cannot be null and are set at 01/01/0001
            return 'Never';
        }
      
        if (diff < 60000) { 
            // less than 1 minute
            return 'Just now';

        } else if (diff < 3600000) { 
            // less than 1 hour
            const minutes = Math.floor(diff / 60000);
            return `${minutes} minute${minutes === 1 ? '' : 's'} ago`;

        } else if (diff < 86400000) { 
            // less than 1 day
            const hours = Math.floor(diff / 3600000);
            return `${hours} hour${hours === 1 ? '' : 's'} ago`;

        } else if (diff < 604800000) { 
            // less than 7 days
            const days = Math.floor(diff / 86400000);
            return `${days} day${days === 1 ? '' : 's'} ago`;

        } else { 
            // more than 7 days
            const months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
            const year = created.getFullYear();
            const month = months[created.getMonth()];
            const day = created.getDate();
            return `${month} ${day}, ${year}`;
        }
    }
}

export default new DateTimeProvider();
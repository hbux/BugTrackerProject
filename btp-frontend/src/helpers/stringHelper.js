class StringHelper {
    pluralise(count, word) {
        // pluralises a word based on the number (count) provided
        if (count == 0 || count > 1) {
            return word + 's';
        }
        
        return word;
    }
}

export default new StringHelper();
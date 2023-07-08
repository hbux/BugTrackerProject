class StorageProvider {
    storageKey = 'user_identity';

    getUser() {
        let user = JSON.parse(localStorage.getItem(this.storageKey));

        return user;
    }

    setUser(user) {
        localStorage.setItem(this.storageKey, JSON.stringify(user));
    }

    removeUser() {
        localStorage.removeItem(this.storageKey);
    }
}

export default new StorageProvider();
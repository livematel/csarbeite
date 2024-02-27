    public int UpdateOrder
        {
            get { return _updateOrder; }
            set
            {
                if (_updateOrder != value)
                {
                    _updateOrder = value;
                    OnUpdateOrderChanged(this, EventArgs.Empty);
                }
            }
        }//babubu
        protected override void InsertItem(int index, IGameComponent item)
        {
            if (base.IndexOf(item) != -1)
            {
                throw new ArgumentException("Cannot Add Same Component Multiple Times");
            }
            base.InsertItem(index, item);
            if (item != null)
            {
                this.OnComponentAdded(new GameComponentCollectionEventArgs(item));
            }
        }	protected GamePlatform(Game game)
        {
            if (game == null)
                throw new ArgumentNullException("game");
            Game = game;
        }
